#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoCompras.Context;
using GestaoCompras.Models;

namespace GestaoCompras.Controllers
{
    public class FornecedorFisicoController : Controller
    {
        public IFornecedorFisicoService _fornecedorFisicoService;

        public FornecedorFisicoController(IFornecedorFisicoService fornecedorFisicoService)
        {
            _fornecedorFisicoService = fornecedorFisicoService;
        }

        // GET: FornecedorFisico
        public async Task<IActionResult> Index(string cpf, string nome, int? nacional)
        {
            ViewData["Title"] = "Lista de Fornecedores Fisicos";

            var listaFornecedoresFisicos = _fornecedorFisicoService.Index(cpf, nome, nacional).Result;

            return View(listaFornecedoresFisicos);
        }

        // GET: FornecedorFisico/Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Cadastrar Fornecedor Fisico";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FornecedorFisico fornecedorFisico)
        {
            if (ModelState.IsValid)
            {
               await _fornecedorFisicoService.Create(fornecedorFisico);
                return RedirectToAction("Index");

            }
            return View(fornecedorFisico);

        }

        public async Task<IActionResult> Edit(int? id)
        {

            var fornecedorFisico = _fornecedorFisicoService.Edit(id).Result;

            ViewData["Title"] = "Editar Fornecedor Fisico";

            return View("Create", fornecedorFisico);
        }

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             await _fornecedorFisicoService.DeleteConfirmed(id);
            return RedirectToAction("Index");
        }
    }
}
