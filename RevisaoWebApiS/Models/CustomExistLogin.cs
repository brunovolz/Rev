using RevisaoWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWebApiS.Models
{
    public class CustomExistLogin : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                Usuario user = ContextDB.GetInstance().usuarios.FirstOrDefault(x => x.Login == value.ToString());

                if (user == null)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Login já existe!");
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório");
        }
    }
}