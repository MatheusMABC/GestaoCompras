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
    public class FornecedorJuridicoController : Controller
    {

        public IFornecedorJuridicoService _fornecedorJuridicoService;

        public FornecedorJuridicoController(IFornecedorJuridicoService fornecedorJuridicoService)
        {
            _fornecedorJuridicoService = fornecedorJuridicoService;
        }

        // GET: FornecedorJuridico
        public async Task<IActionResult> Index(string cnpj, string razaoSocial, int? nacional, int? porte)
        {
            ViewData["Title"] = "Listar Fornecedores Juridicos";

            return View(await _fornecedorJuridicoService.Index(cnpj, razaoSocial, nacional, porte));
        }
        // GET: FornecedorJuridico/Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Cadastrar Fornecedor Juridico";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FornecedorJuridico fornecedorJuridico)
        {
            if (ModelState.IsValid)
            {
                await _fornecedorJuridicoService.Create(fornecedorJuridico);

                return RedirectToAction(nameof(Index));

            }
            return View(fornecedorJuridico);

        }

        // GET: FornecedorJuridico/ID
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var FornecedorJuridico = await _fornecedorJuridicoService.Edit(id);
            if (FornecedorJuridico == null)
            {
                return NotFound();
            }
            ViewData["Title"] = "Editar Fornecedor Juridico";

            return View("Create", FornecedorJuridico);
        }
        // DELETE: FornecedorJuridico/ID

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _fornecedorJuridicoService.DeleteConfirmed(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
