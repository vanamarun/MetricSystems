using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        [HttpGet]
            public IActionResult Fahrenheit()
            {
                return View(new TemperatureModel());
            }

        [HttpPost]
        public IActionResult Fahrenheit(TemperatureModel model)
        {
            if (ModelState.IsValid)
            {
                // This line performs the Fahrenheit to Celsius conversion
                model.Result = (model.Fahrenheit - 32) * 5 / 9;
            }
            // This returns the updated 'model' object, which now contains the result
            return View(model);
        }
    }
}