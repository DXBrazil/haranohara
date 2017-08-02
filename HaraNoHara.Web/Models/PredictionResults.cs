using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace HaraNoHara.Web.Models
{
    public class PredictionResults
    {
        [Key]
        public int Id { get; set; }
       public string tag { get; set; }
        public double prediction { get; set; }
    }
}