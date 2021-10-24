using Microsoft.AspNetCore.Mvc;
using Sharks.Sprint04.Web.Models;
using Sharks.Sprint04.Web.Persistencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sharks.Sprint04.Web.Controllers
{
    public class ChuveiroController : Controller
    {
        // Atributo para armazenar o context
        private SharksContext _context;

        // Construtor que recebe a injeção de dependência do Context
        public ChuveiroController(SharksContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var chuveiro = _context.Chuveiros.Find(id);
            _context.Chuveiros.Remove(chuveiro);
            _context.SaveChanges(); // commit
            TempData["msg"] = "Chuveiro removido!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var chuveiro = _context.Chuveiros.Find(id);
            return View(chuveiro);
        }

        [HttpPost]
        public IActionResult Editar(Chuveiro chuveiro)
        {
            _context.Chuveiros.Update(chuveiro);
            _context.SaveChanges();
            TempData["msg"] = "Chuveiro atualizado!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Chuveiro chuveiro)
        {
            _context.Chuveiros.Add(chuveiro);
            _context.SaveChanges();
            TempData["msg"] = "Chuveiro cadastrado!";
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
