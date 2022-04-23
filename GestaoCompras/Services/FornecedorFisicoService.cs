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
        public async Task<List<FornecedorFisico>> Index(string cpf, string nome, string nacional)
        {
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
            return listaFornecedoresFisicos.ToList();
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
