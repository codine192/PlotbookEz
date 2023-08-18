﻿using System;
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
        public int ResidentID { get; set; }
        public int MarkerID { get; set; }
        public int PlotbookID { get; set; }
        public virtual PlotBook PlotBook { get; set; }
        public virtual Marker Marker { get; set; }
        public virtual Resident Resident { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}

