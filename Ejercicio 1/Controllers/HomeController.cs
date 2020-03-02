using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio_1.Models;

namespace Ejercicio_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Binarios());
        }

        [HttpPost]
        public IActionResult Index(Binarios b, string btnSubmit)
        {
            if(btnSubmit == "Calcular")
            {
                for (int i = 0; i < 10; i++)
                {
                    b.Numeros[i] = int.Parse(Request.Form["num"][i]);
                    b.Binario[i] = Convert.ToString(b.Numeros[i], 2);
                }   
            }

            return View(b);
        }


    }
}
