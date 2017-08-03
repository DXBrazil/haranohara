using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;


namespace HaraNoHara.Web.Models
{
    public class PredictionResults
    {
        
        public int Id { get; set; }
        public Bitmap HaraImage { get; set; }

        public string tag;

        public double prediction;
     
    }
}