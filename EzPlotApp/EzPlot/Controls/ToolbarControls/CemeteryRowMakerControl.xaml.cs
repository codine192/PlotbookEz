using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EzPlot.Controls
{
    /// <summary>
    /// Interaction logic for CemeteryRowMakerControl.xaml
    /// </summary>
    public partial class CemeteryRowMakerControl : UserControl
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public CemeteryRowMakerControl()
        {
            InitializeComponent();
        }
        
        public void SetRowsAndColumns(int rows, int columns)
        {
            CemeteryGrid.Children.Clear();
            CemeteryGrid.RowDefinitions.Clear();
            CemeteryGrid.ColumnDefinitions.Clear();
            CemeteryGrid.ShowGridLines = true;
            Rows = rows;
            Columns = columns;
            for (int i = 0; i < rows; i++)
            {
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(1, GridUnitType.Star);
                CemeteryGrid.RowDefinitions.Add(row);
            }
            for (int i = 0; i < columns; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(1, GridUnitType.Star);
                CemeteryGrid.ColumnDefinitions.Add(column);
            }
        }

    }    
}
