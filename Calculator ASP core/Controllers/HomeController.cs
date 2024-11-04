using Calculator_ASP_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_ASP_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Clear()
        {
            return View("Index");
        }

        public IActionResult Sum(CalData data)
        {
            data.Operation = CalData.Operations.Sumproduct;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Sub(CalData data)
        {
            data.Operation = CalData.Operations.Subtraction;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Cro(CalData data)
        {
            data.Operation = CalData.Operations.Crossproduct;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Div(CalData data)
        {
            data.Operation = CalData.Operations.Divition;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Fac(CalData data)
        {
            data.Operation = CalData.Operations.Factorial;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Pow(CalData data)
        {
            data.Operation = CalData.Operations.Power;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Roo(CalData data)
        {
            data.Operation = CalData.Operations.Root;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }
        public IActionResult Mod(CalData data)
        {
            data.Operation = CalData.Operations.Mode;
            ViewBag.Result = Calculate(data);
            return View("Index");
        }

        double Calculate(CalData data)
        {
            switch (data.Operation)
            {
                case CalData.Operations.Sumproduct:
                    return data.Value1 + data.Value2;
                case CalData.Operations.Subtraction:
                    return data.Value1 - data.Value2;
                case CalData.Operations.Crossproduct:
                    return data.Value1 * data.Value2;
                case CalData.Operations.Divition:
                    return data.Value1 / data.Value2;
                case CalData.Operations.Factorial:
                    return Fact(data.Value1);
                case CalData.Operations.Power:
                    return Math.Pow(data.Value1, data.Value2);
                case CalData.Operations.Root:
                    return Math.Pow(data.Value1, 1.0 / data.Value2);
                case CalData.Operations.Mode:
                    return data.Value1 % data.Value2;
                default:
                    return 0;
            }
        }

        double Fact(int n)
        {
            int[] f = new int[n+1];
            int i;

            f[0] = 1;

            for (i = 1; i <= n; i++)
                f[i] = i * f[i - 1];

            return f[n];
        }
    }
}