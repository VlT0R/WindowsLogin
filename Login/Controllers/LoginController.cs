using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Entrar()
        {
            return View(0);
        }

        [HttpPost]
        public IActionResult Entrar(string usuario, string senha)
        {
            if(usuario =="admin" && senha == "1234")
            {
                //login efetuado
                return View( 1 );
            }
            else
            {
                return View (2);
            }
        }
    }
}
