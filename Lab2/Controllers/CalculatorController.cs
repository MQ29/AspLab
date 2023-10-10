using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result([FromQuery(Name = "operator")] Operators? op, double?x, double? y) 
        {

            if(x == null || y== null) 
            {
                return View("Error");
            }
            switch(op)
            {
                case Operators.ADD:
                    ViewBag.Result = x + y; 
                    break;

                case Operators.SUB:
                    ViewBag.Result = x - y;
                    break;
                case Operators.MUL:
                    ViewBag.Result = x * y;
                    break;
                case Operators.DIV:
                    ViewBag.Result = x / y;
                    break;


            }
            return View("Result");
        }
    }
}
