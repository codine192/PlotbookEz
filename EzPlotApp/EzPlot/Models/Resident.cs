using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using EzPlot.Converters;

namespace EzPlot.Models
{
    public class Resident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public DateTime DateAdded { get; set; }
        public bool AssignedToPlot { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public byte[]? HeadStoneImageData { get; set; }
        [NotMapped]public BitmapImage HeadStoneImage
        {
            get
            {
                if (HeadStoneImageData != null)
                { return ByteArrayToBitMapImageConverter.Convert(HeadStoneImageData); }
                else
                {
                    return null;
                }
                
            }
        }

    }
}
