using Curso.Infraestructure.Core;
using Curso.Infraestructure.Interfaces;
using Cursos.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Curso.Infraestructure.Context;
using System.Threading.Tasks;

namespace Curso.Infraestructure.Repositories
{
    internal class DepartmentsRepository : BaseRepository<Departments> ,IDepartments
    {
        private readonly CursosContext context;
        private readonly ILogger<DepartmentsRepository> logger;
        public DepartmentsRepository(CursosContext context,
                                   ILogger<DepartmentsRepository> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }
        public async override Task Save(Departments entity)
        {
            try
            {
                await base.Save(entity);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Ocurrió un error guardando la categoria", ex.ToString());
            }
        }
    }
}
