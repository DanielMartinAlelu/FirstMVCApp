using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
           //Pasas a la vista la variable dogs con los datos que lleva guardados
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        //Se llama cuando submiteamos el formulario
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index"); //Con esto retorna a la vista index
            //Aniadimos los dogs creados a la lista
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index)); //Con esto retorna al controller Index de mas arriba, utilizando el modelo
        }

        public string Hello()
        {
            return "Who is there?";
        }
    }
}
