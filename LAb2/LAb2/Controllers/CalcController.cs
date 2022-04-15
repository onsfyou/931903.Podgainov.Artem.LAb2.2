using Microsoft.AspNetCore.Mvc;
using LAb2.Services;
using LAb2.Models;
namespace LAb2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Manual()
        {
            ViewData["Title"] = "Manual";
            if (Request.Method == "POST")
            {
                bool result;
                result = int.TryParse(HttpContext.Request.Form["a"], out int a);
                result = int.TryParse(HttpContext.Request.Form["b"], out int b);
                string op = HttpContext.Request.Form["operation"];
                ViewData["Result"] = CalcService.Operation(a, b, op);
                return View("Result");
            }
            return View("Form");
        }

        [HttpGet]
        [ActionName("ManualWithSeparateHandlers")]
        public IActionResult ManualWithSeparateHandlersGet()
        {
            ViewData["Title"] = "ManualWithSeparateHandlers";
            return View("Form");
        }

        [HttpPost]
        [ActionName("ManualWithSeparateHandlers")]
        public IActionResult ManualWithSeparateHandlersPost()
        {
            bool result;
            result = int.TryParse(HttpContext.Request.Form["a"], out int a);
            result = int.TryParse(HttpContext.Request.Form["b"], out int b);
            string op = HttpContext.Request.Form["operation"];
            ViewData["Result"] = CalcService.Operation(a, b, op);
            return View("Result");
        }
        
        [HttpGet]
        public IActionResult ModelBindingInParametrs()
        {
            ViewData["Title"] = "ModelBuildingInParameters";
            return View("Form");
        }
        [HttpPost]
        public IActionResult ModelBindingInParametrs(int a, string operation, int b)
        {
            ViewData["Title"] = "ModelBuildingInParameters";
            ViewData["Result"] = CalcService.Operation(a, b, operation);
            return View("Result");
        }

        [HttpGet]
        public IActionResult ModelBindingInSeparateModel()
        {
            ViewData["Title"] = "ModelBuildingInSeparateModel";
            return View("Form");
        }
        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(CalcModel calcModel)
        {
            ViewData["Title"] = "ModelBuildingInSeparateModel";
            ViewData["Result"] = calcModel.GetValue();
            return View("Result");
        }
    }
}
