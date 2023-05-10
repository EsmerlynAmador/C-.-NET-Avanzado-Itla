using System;
using System.Collections.Generic;
using System.Text;
using Cursos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Curso.Infraestructure.Context
{
    public partial class AlmacenContext
    {
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
    }
}
