using Microsoft.AspNetCore.Mvc;

namespace RazorDivertido.Controllers{
    public class HomeController : Controller {
        [HttpGet]
        [Route("")]
        public ViewResult Index(){
            return View();
        }

}

}
