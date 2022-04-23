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
        public async Task<List<FornecedorJuridico>> Index(string cpf, string nome, string nacional)
        {
            var listaFornecedorJuridico = await _context.FornecedorJuridico.ToListAsync();
            if (cpf != null)
            {
                listaFornecedorJuridico.Where(t => t.Cnpj.Trim() == cpf.Trim().Replace(".", "").Replace("-", "")).ToList();
            }
            if (nome != null)
            {
                listaFornecedorJuridico.Where(t => t.NomeFantasia.Trim().ToUpper() == nome.Trim().ToUpper()).ToList();

            }
            if (nacional != null)
            {
                var opcaoNacional = Convert.ToInt32(nacional) == 0 ? "Sim" : "Não";
                listaFornecedorJuridico.Where(t => Convert.ToString(t.Nacional).Trim().ToUpper() == opcaoNacional.Trim().ToUpper()).ToList();

            }
            return listaFornecedorJuridico.ToList();
        }

    }
}
