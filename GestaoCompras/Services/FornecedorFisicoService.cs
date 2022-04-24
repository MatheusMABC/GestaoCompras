#nullable disable
using GestaoCompras.Context;
using GestaoCompras.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoCompras.Controllers
{
    public class FornecedorFisicoService : IFornecedorFisicoService
    {
        private readonly DBContext _context;
        public FornecedorFisicoService(DBContext context)
        {
            _context = context;
        }
        public async Task<List<FornecedorFisico>> Index(string cpf, string nome, int? nacional)
        {
            IQueryable<FornecedorFisico> query = _context.FornecedorFisico;
            if (cpf != null)
            {
                var cpfFormatado = cpf.Trim().Replace(".", "").Replace("-", "");
                query = query.Where(x => x.Cpf == cpfFormatado);
            }
            if (nome != null)
            {
                query = query.Where(t => t.Nome.Trim().ToUpper() == nome.Trim().ToUpper());
            }
            if (nacional != null)
            {
                query = query.Where(t =>(int)t.NacionalFisico == nacional);

            }
            var listaFornecedoresFisicos = await query.ToListAsync();
            return listaFornecedoresFisicos;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create(FornecedorFisico fornecedorFisico)
        {

            fornecedorFisico.Cpf = fornecedorFisico.Cpf.Replace(".", "").Replace("-", "");

            if (fornecedorFisico.Id == 0)
            {
                fornecedorFisico.DataCadastro = DateTime.UtcNow;
                fornecedorFisico.DataUltimaAtualizacao = DateTime.UtcNow;

                await _context.AddAsync(fornecedorFisico);
            }
            else
            {
                fornecedorFisico.DataUltimaAtualizacao = DateTime.UtcNow;
                _context.Entry(fornecedorFisico).Property(x => x.Id).IsModified = false;

                _context.Update(fornecedorFisico);

            }
            await _context.SaveChangesAsync();
        }

        public async Task<FornecedorFisico> Edit(int? id)
        {
            var fornecedorFisico = await _context.FornecedorFisico.FindAsync(id);
            return fornecedorFisico;
        }

        public async Task DeleteConfirmed(int id)
        {
            var fornecedorFisico = await _context.FornecedorFisico.FindAsync(id);
            _context.FornecedorFisico.Remove(fornecedorFisico);
            await _context.SaveChangesAsync();
        }
    }
}
