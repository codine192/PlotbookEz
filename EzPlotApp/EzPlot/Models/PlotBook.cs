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
        public int ID { get; set; }
        public int CemeteryID { get; set; }
        public virtual Cemetery Cemetery { get; set; }
        public string name { get; set; }
        public ICollection<Plot> Plots { get; set; }
        public byte[] image { get; set; }
        public virtual Image Image { get; set; }
        
        
        
    }
    

}
