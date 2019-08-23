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
        [CustomNameValidator]
        public string Nome { get; set; }
        [RegularExpression(pattern: @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
        [CustomExistLogin]
        public string Login { get; set; }
        [MaxLength(16,ErrorMessage ="Limite de cacacteres excedido \"16\"")]
        [MinLength(8,ErrorMessage ="Quantidade insuficiente de caractereces \"8\"")]
        public string Senha { get; set; }

    }
}