using RevisaoWebApiS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace RevisaoWebApi.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }
        [CustomValidFields(RevisaoWebApiS.Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }
        [CustomValidFields(RevisaoWebApiS.Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }
        [CustomValidFields(RevisaoWebApiS.Enums.ValidFields.ValidaLogin)]
        public string Login { get; set; }
        [CustomValidFields(RevisaoWebApiS.Enums.ValidFields.ValidaSenha)]
        public string Senha { get; set; }

    }
}