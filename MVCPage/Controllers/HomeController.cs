using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCPage.Models;

namespace MVCPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Apresenta o menu inicial
            return View();
        }

        public IActionResult ListaClientes()
        {
            // Retornar uma view com a lista de clientes
            return View(Dados.TodosClientes());
        }

        public IActionResult AdicionarClientes()
        {
            return View();
        }

        // O objeto cliente será enviado para essa função depois de ser submetido no formulário
        [HttpPost]
        public IActionResult AdicionarClientes(Cliente cliente)
        {
            Dados.AdicionarClientes(cliente);
            return RedirectToAction("AdicionarClientes");
            // retornaremos para a View de adicionar clientes para que possamos continuar inserindo mais dados
        }

        public IActionResult EditarClientes(int id)
        {
            return View(Dados.DadosCliente(id));
        }

        [HttpPost]
        public IActionResult EditarClientes(Cliente c)
        {
            // Recebemos um cliente para editar
            Dados.EditarClientes(c);
            return RedirectToAction("ListaClientes");
        }

        public IActionResult RemoverClientes(int id)
        {
            Dados.RemoverClientes(id);
            return RedirectToAction("ListaClientes");
        }
    }
}
