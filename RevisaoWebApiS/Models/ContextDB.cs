using RevisaoWebApiS.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class ContextDB : Single<ContextDB>
    {
        public DbSet<Usuario> usuarios { get; set; }

    }
}