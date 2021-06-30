using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcularorWebApplication.Controllers
{
    public class HomeController : Controller
    {
        double result;
        double secondresult;

        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "multiply", Text ="Умножение" },
                new SelectListItem() { Value = "sum", Text ="Сумма" },
                new SelectListItem() { Value = "minus", Text ="Разность" },
                new SelectListItem() { Value = "division", Text ="Деление" },
                new SelectListItem() { Value = "sin", Text ="sin (Первое окно)" },
                new SelectListItem() { Value = "cos", Text ="cos (Первое окно)" }
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
            double firstNumber,
            double secondNumber,
            string operation)
        {
            switch (operation)
            {
                case "multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "sum":
                    result = firstNumber + secondNumber;
                    break;
                case "minus":
                    result = firstNumber - secondNumber;
                    break;
                case "division":
                    result = firstNumber / secondNumber;
                    break;
                case "sin":
                    result = Math.Sin(firstNumber);
                    break;
                case "cos":
                    result = Math.Cos(firstNumber);
                    break;
            }

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "multiply", Text ="Умножение" },
                new SelectListItem() { Value = "sum", Text ="Сумма" },
                new SelectListItem() { Value = "minus", Text ="Разность" },
                new SelectListItem() { Value = "division", Text ="Деление" },
                new SelectListItem() { Value = "sin", Text ="sin (Первое окно)" },
                new SelectListItem() { Value = "cos", Text ="cos (Первое окно)" }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Калькулятор с возможностью суммы, разности, умножение, деления и нахождения синуса и косинуса";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Авторы работы:";

            return View();
        }

    }
}