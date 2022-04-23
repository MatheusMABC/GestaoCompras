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
    public interface IFornecedorFisicoService
    {
        Task Create(FornecedorFisico fornecedorFisico);
        Task<FornecedorFisico> Edit(int? id);
        Task DeleteConfirmed(int id);
        Task<List<FornecedorFisico>> Index(string cpf, string nome, string nacional);

    }
}
