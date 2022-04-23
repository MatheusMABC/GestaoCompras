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
        private readonly DBContext _context;

        public FornecedorFisicoController(DBContext context)
        {
            _context = context;
        }

        // GET: FornecedorFisico
        public async Task<IActionResult> Index(string cpf, string nome, string nacional)
        {
            ViewData["Title"] = "Lista de Fornecedores Fisicos";
            var listaFornecedoresFisicos = await _context.FornecedorFisico.ToListAsync();
            if (cpf != null)
            {
                listaFornecedoresFisicos.Where(t => t.Cpf.Trim() == cpf.Trim().Replace(".", "").Replace("-", "")).ToList();
            }
            if (nome != null)
            {
                listaFornecedoresFisicos.Where(t => t.Nome.Trim().ToUpper() == nome.Trim().ToUpper()).ToList();

            }
            if (nacional != null)
            {
                var opcaoNacional = Convert.ToInt32(nacional) == 0 ? "Sim" : "Não";
                listaFornecedoresFisicos.Where(t => Convert.ToString(t.NacionalFisico).Trim().ToUpper() == opcaoNacional.Trim().ToUpper()).ToList();

            }
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
                fornecedorFisico.Cpf = fornecedorFisico.Cpf.Replace(".", "").Replace("-", "");

                if (fornecedorFisico.Id == 0)
                {
                    fornecedorFisico.DataCadastro = DateTime.UtcNow;

                    await _context.AddAsync(fornecedorFisico);
                }
                else
                {
                    fornecedorFisico.DataUltimaAtualizacao = DateTime.UtcNow;
                    _context.Entry(fornecedorFisico).Property(x => x.Id).IsModified = false;

                    _context.Update(fornecedorFisico);

                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(fornecedorFisico);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedorFisico = await _context.FornecedorFisico.FindAsync(id);
            if (fornecedorFisico == null)
            {
                return NotFound();
            }
            ViewData["Title"] = "Editar Fornecedor Fisico";

            return View("Create", fornecedorFisico);
        }

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fornecedorFisico = await _context.FornecedorFisico.FindAsync(id);
            _context.FornecedorFisico.Remove(fornecedorFisico);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
