using Cursos.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class Instructors : BaseEntity
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contacto { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
    }
}
