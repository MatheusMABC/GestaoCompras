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
    public interface IFornecedorJuridicoService
    {
        Task Create(FornecedorJuridico fornecedorFisico);
        Task<FornecedorJuridico> Edit(int? id);
        Task DeleteConfirmed(int id);
        Task<List<FornecedorJuridico>> Index(string cpf, string nome, string nacional);
    }
}
