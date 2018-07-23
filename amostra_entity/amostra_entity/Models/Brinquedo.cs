using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace amostra_entity.Models
{
    public class Brinquedo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int lojaId { get; set; }
        public int criancaId { get; set; }
    }
}