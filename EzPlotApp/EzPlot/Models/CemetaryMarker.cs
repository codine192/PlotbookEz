using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EzPlot.Converters;
namespace EzPlot.Models
{
    public class CemetaryMarker : UIElement
    {
        [TypeConverter(typeof(DoubleTypeConverter))]
        public double X { get; set; }  // X-coordinate
        [TypeConverter(typeof(DoubleTypeConverter))]
        public double Y { get; set; }  // Y-coordinate
        public string? MarkerLabel { get; set; }  // Marker label or name
        public string Type { get; set; }  // Type of marker (e.g., grave, monument)
        [TypeConverter(typeof(IntTypeConverter))]
        public int PlotID { get; set; }
    }
}
