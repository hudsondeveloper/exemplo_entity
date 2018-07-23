using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace amostra_entity.Models
{
    public class Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Context() : base("name=Context")
        {
        }

        public System.Data.Entity.DbSet<amostra_entity.Models.Brinquedo> Brinquedoes { get; set; }

        public System.Data.Entity.DbSet<amostra_entity.Models.Crianca> Criancas { get; set; }

        public System.Data.Entity.DbSet<amostra_entity.Models.Loja> Lojas { get; set; }
    }
}
