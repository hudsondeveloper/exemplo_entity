using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace amostra_entity.Models
{
    public class Crianca
    {
        public int id { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Brinquedo> Brinquedos { get; set; }
    }
}