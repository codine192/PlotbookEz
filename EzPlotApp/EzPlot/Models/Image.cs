using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace EzPlot.Models
{
    public class Image 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Required] public byte[] ImageData { get; set; }
        [Required] public string Filename { get; set; }
        
        [Required]public int Y = 0;
        [Required]public int X = 0;
        [Required]public int Zoom = 0;
         
        
    }
}
