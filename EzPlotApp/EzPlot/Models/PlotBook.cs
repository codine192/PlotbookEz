using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EzPlot.Models
{

    public class PlotBook
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required] public int plotBookID { get; set; }
        [Required] public int cemetaryID { get; set; }
        [Required] public string name { get; set; }
        [Required] public List<Plot> plotList { get; set; }
        [Required] public byte[] image { get; set; }
        [Required] public virtual Image Image { get; set; }
        [NotMapped] public virtual Cemetary cemetary { get; set; }
        
        
    }
    

}
