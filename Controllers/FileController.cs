using Microsoft.AspNetCore.Mvc;

namespace systemquchooch.Controllers
{
    public class FileController : Controller
    {
        public IActionResult MostrarImagen()
        {
            return File("~/img/comunidad.jpg", "image/jpg");
        }
    }
}
