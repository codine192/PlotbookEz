using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


using EzPlot.Models;
using System.Windows.Media.Imaging;

namespace EzPlot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        public static PlotBook SelectedPlotBook { get; set; }
        
        public static BitmapImage defaultImage { get; set; }
        public IConfiguration Configuration { get; private set; }
        public App()
        {
            var builder = new ConfigurationBuilder()
                
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            using (var context = new MYDBContext())
            {
                
                SelectedPlotBook = context.PlotBooks.FirstOrDefault();
                if (SelectedPlotBook != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(SelectedPlotBook.image))
                    {
                        BitmapImage image = new BitmapImage();
                        image.BeginInit();
                        image.CacheOption = BitmapCacheOption.OnLoad;
                        image.StreamSource = memoryStream;
                        image.EndInit();
                        defaultImage = image;
                    }
                }
            }

            Configuration = builder.Build();
            
        }
    }
}
