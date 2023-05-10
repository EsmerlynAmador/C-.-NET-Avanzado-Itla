﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Core
{
    public abstract class BaseEntity
    {
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public int IdUsuarioElimino { get; set; }
        public DateTime FechaElimino { get; set; }
        public bool Eliminado { get; set; }
    }
}
