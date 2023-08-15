using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EzPlot.Models
{
    public class Plot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //public virtual Resident Resident { get; set; }
         [Required]public int CemetaryID { get; set; }
        //Properties for Plot
        [Required] public int PlotbookID { get; set; }
                    
        [Required]public double X { get; set; }
        [Required] public double Y { get; set; }
        [Required] public double Width { get; set; }
        [Required] public double Height { get; set; }
    }
}
