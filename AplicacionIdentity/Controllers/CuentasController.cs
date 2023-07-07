using AplicacionIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionIdentity.Controllers
{
    public class CuentasController : Controller
    {
        //Dependencias
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        //Constructor 

        public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Index()
        {
            return View();
        }

        //Registro de usuarios
        [HttpGet]
        //Vista del registro

        public async Task<IActionResult> Registro()
        {
            Registrar claseRegistrar = new Registrar();
            return View(claseRegistrar);
        }

        //Datos a enviar en el formulario

        [HttpPost]
        public async Task<IActionResult> Registro(Registrar claseRegistrar)
        {
            if(ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    UserName = claseRegistrar.Email,
                    Email = claseRegistrar.Email,
                    nombres = claseRegistrar.Nombres,
                    apellidos = claseRegistrar.Apellidos,

                };
                var resultado = await _userManager.CreateAsync(usuario, claseRegistrar. Password);
                await _signInManager.SignInAsync(usuario, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            return View(claseRegistrar);

        }
    }
}
