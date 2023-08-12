using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPlot.Models
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageID { get; set; }
        [ForeignKey("PlotBooks")] public int PlotBookID { get; set; }
        [Required] public byte[] ImageData { get; set; }
        [Required] public string Filename { get; set; }
    }
}
