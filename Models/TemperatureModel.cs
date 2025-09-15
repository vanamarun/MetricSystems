using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage = "The Fahrenheit field is required.")]
        [Range(-459.67, 1000, ErrorMessage = "Please enter a value between -459.67 and 1000.")]
        public double Fahrenheit { get; set; }

        public double Result { get; set; }
    }
}