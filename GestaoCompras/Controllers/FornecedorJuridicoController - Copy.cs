//#nullable disable
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using GestaoCompras.Context;
//using GestaoCompras.Models;

//namespace GestaoCompras.Controllers
//{
//    public class FornecedorJuridicoController : Controller
//    {
//        private readonly DBContext _context;

//        public FornecedorJuridicoController(DBContext context)
//        {
//            _context = context;
//        }

//        // GET: FornecedorJuridico
//        public async Task<IActionResult> Index()
//        {
//            ViewData["Title"] = "Listar Fornecedores Juridicos";

//            return View(await _context.FornecedorJuridico.ToListAsync());
//        }
//        // GET: FornecedorJuridico/Create
//        public IActionResult Create()
//        {
//            ViewData["Title"] = "Cadastrar Fornecedor Juridico";
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(FornecedorJuridico fornecedorJuridico)
//        {
//            if (ModelState.IsValid)
//            {
//                fornecedorJuridico.Cnpj = fornecedorJuridico.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

//                if (fornecedorJuridico.Id == 0)
//                {
//                    fornecedorJuridico.DataCadastro = DateTime.UtcNow;
//                    fornecedorJuridico.DataUltimaAtualizacao = DateTime.UtcNow;

//                    await _context.AddAsync(fornecedorJuridico);
//                }
//                else
//                {
//                    fornecedorJuridico.DataUltimaAtualizacao = DateTime.UtcNow;
//                    _context.Entry(fornecedorJuridico).Property(x => x.Id).IsModified = false;

//                    _context.Update(fornecedorJuridico);

//                }

//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));

//            }
//            return View(fornecedorJuridico);

//        }

//        // GET: FornecedorJuridico/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var FornecedorJuridico = await _context.FornecedorJuridico.FindAsync(id);
//            if (FornecedorJuridico == null)
//            {
//                return NotFound();
//            }
//            ViewData["Title"] = "Editar Fornecedor Juridico";

//            return View("Create", FornecedorJuridico);
//        }

//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var FornecedorJuridico = await _context.FornecedorJuridico.FindAsync(id);
//            _context.FornecedorJuridico.Remove(FornecedorJuridico);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool FornecedorJuridicoExists(int id)
//        {
//            return _context.FornecedorJuridico.Any(e => e.Id == id);
//        }
//    }
//}
