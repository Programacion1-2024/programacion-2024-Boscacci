﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public int PrecioVenta { get; set; }
    }
}
