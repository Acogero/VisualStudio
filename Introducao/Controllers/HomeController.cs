using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                idPessoa = 1,
                nomePessoa = "João Almeida",
                tipoFuncionario = "Estagiário"
            };

            //Associando as informações na view
            /*
            ViewData["idPessoa"] = pessoa.idPessoa;
            ViewData["nomePessoa"] = pessoa.nomePessoa;
            ViewData["tipoFuncionario"] = pessoa.tipoFuncionario;
            */

            /*
            ViewBag.idPessoa = pessoa.idPessoa;
            ViewBag.nomePessoa = pessoa.nomePessoa;
            ViewBag.tipoFuncionario = pessoa.tipoFuncionario;
            */

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        //Toda vez que houver alguma requisição HTTP é necessário informar com a anotação abaixo
        [HttpPost]
        /*
        public ActionResult Lista(FormCollection form)
        {
            //form["idPessoa"] é o id ou nome do campo em index
            ViewData["idPessoa"] = form["idPessoa"];
            ViewData["nomePessoa"] = form["nomePessoa"];
            ViewData["tipoFuncionario"] = form["tipoFuncionario"];

            return View();
        }
        */

            /*
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["idPessoa"] = pessoa.idPessoa;
            ViewData["nomePessoa"] = pessoa.nomePessoa;
            ViewData["tipoFuncionario"] = pessoa.tipoFuncionario;
            return View();
        }
        */

        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}