using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfMVC.Web.Models
{
    public class Racquet
    {
        public virtual int RacquetId { get; set; }
        public virtual int ManufacturerId { get; set; }
        public string Name { get; set; }
        public double HeadSize { get; set; }
        public float Length { get; set; }
        public float StrungWeight { get; set; }
        public double SwingWeight { get; set; }
        public double Stiffness { get; set; }
        public string PowerLevel { get; set; }
        public string StrokeStyle { get; set; }
        public string SwingSpeed { get; set; }
        public string StringPattern { get; set; }
        public bool SmartSensorReady { get; set; }
        public decimal Price { get; set; } 
    }
}