using Microsoft.AspNetCore.Mvc;
using Sharks.Sprint04.Web.Models;
using Sharks.Sprint04.Web.Persistencias;
using System.Linq;

namespace Sharks.Sprint04.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // Atributo para armazenar o context
        private SharksContext _context;

        // Construtor que recebe a injeção de dependência do Context
        public UsuarioController(SharksContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges(); // commit
            TempData["msg"] = "Usuário removido!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            TempData["msg"] = "Usuário atualizado!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            TempData["msg"] = "Usuário cadastrado!";
            return RedirectToAction("Index");
        }

        public IActionResult Index(string nomeBusca, Pressao? pressaoBusca)
        {
            // Pesquisar por parte do nome
            var lista = _context.Usuarios.Where(m =>
                (m.Nome.Contains(nomeBusca) || nomeBusca == null) &&
                (m.Pressao == pressaoBusca || pressaoBusca == null)).ToList();
            // Envia a lista de musicas para a view
            return View(lista);
        }

    }
}
