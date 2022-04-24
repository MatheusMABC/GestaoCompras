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
    public class FornecedorJuridicoService: IFornecedorJuridicoService
    {
        private readonly DBContext _context;

        public FornecedorJuridicoService(DBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create(FornecedorJuridico fornecedorJuridico)
        {
            try
            {
                fornecedorJuridico.Cnpj = fornecedorJuridico.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "");
                fornecedorJuridico.Telefone1 = fornecedorJuridico.Telefone1.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                fornecedorJuridico.Telefone2 = fornecedorJuridico.Telefone2.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                fornecedorJuridico.Telefone3 = fornecedorJuridico.Telefone3.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

                if (fornecedorJuridico.Id == 0)
                {
                    fornecedorJuridico.DataCadastro = DateTime.UtcNow;
                    fornecedorJuridico.DataUltimaAtualizacao = DateTime.UtcNow;

                    await _context.AddAsync(fornecedorJuridico);
                }
                else
                {
                    fornecedorJuridico.DataUltimaAtualizacao = DateTime.UtcNow;
                    _context.Entry(fornecedorJuridico).Property(x => x.Id).IsModified = false;

                    _context.Update(fornecedorJuridico);

                }

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public async Task DeleteConfirmed(int id)
        {

            var fornecedorJuridico = await _context.FornecedorJuridico.FindAsync(id);
            _context.FornecedorJuridico.Remove(fornecedorJuridico);
            await _context.SaveChangesAsync();


        }

        public async Task<FornecedorJuridico> Edit(int? id)
        {
            var fornecedorJuridico = await _context.FornecedorJuridico.FindAsync(id);
            return fornecedorJuridico;
        }

        // GET: FornecedorFisico
        public async Task<List<FornecedorJuridico>> Index(string cnpj, string razaoSocial, int? nacional)
        {
            IQueryable<FornecedorJuridico> query = _context.FornecedorJuridico;
            if (cnpj != null)
            {
                var cnpjFormatado = cnpj.Trim().Replace(".", "").Replace("/", "").Replace("-","");
                query = query.Where(x => x.Cnpj == cnpjFormatado);
            }
            if (razaoSocial != null)
            {
                query = query.Where(t => t.RazaoSocial.Trim().ToUpper() == razaoSocial.Trim().ToUpper());
            }
            if (nacional != null)
            {
                query = query.Where(t => (int)t.Nacional == nacional);

            }
            var listaFornecedoresJuridicos = await query.ToListAsync();
            return listaFornecedoresJuridicos;

        }

    }
}
