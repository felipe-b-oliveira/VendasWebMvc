using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vendasWebMvc.Models;

namespace vendasWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            list.Add(new Departamento { Id = 2, Nome = "Eletrodomésticos" });

            return View(list);
        }
    }
}