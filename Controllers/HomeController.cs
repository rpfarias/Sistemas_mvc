using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Rafael Farias",
                Tipo = "Administrador"
            };
            
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewBag.nome = pessoa.Nome;

            return View(pessoa);
        }   
            

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)//modelo via View Tipada
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View(pessoa);
        }
    }
}