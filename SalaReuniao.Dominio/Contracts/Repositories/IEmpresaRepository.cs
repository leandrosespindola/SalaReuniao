﻿using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Contracts.Repositories
{
    public interface IEmpresaRepository : IBaseRepository<Empresa, int>
    {
    }
}
