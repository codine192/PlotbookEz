using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EzPlot.Converters
{
    public static class ByteArrayToBitMapImageConverter 

    {
        public static BitmapImage Convert(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException("bytes");
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = memoryStream;
                image.EndInit();
                return image;
            }
        }

    }
}
