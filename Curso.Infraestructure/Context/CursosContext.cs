using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Infraestructure.Context
{
    public class CursosContext : DbContext
    {
        public CursosContext()
        {

        }

        public CursosContext(DbContextOptions<CursosContext> options) : base(options)
        { 

        }
    }
}
