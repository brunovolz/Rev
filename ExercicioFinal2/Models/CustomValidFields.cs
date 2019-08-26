using ExercicioFinal2.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ExercicioFinal2.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB db = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNome:
                        { return ValidarNome(value, validationContext.DisplayName); }
                    case ValidFields.ValidaStatus:
                        break;
                    case ValidFields.ValidaCpfCnpj:
                        break;
                    case ValidFields.ValidaNomeFantasia:
                        break;
                    case ValidFields.ValidaCep:
                        break;
                    case ValidFields.ValidaEndereco:
                        break;
                    case ValidFields.ValidaCidade:
                        break;
                    case ValidFields.ValidaEstado:
                        break;
                    case ValidFields.ValidaTelefone:
                        break;
                    case ValidFields.ValidaCelular:
                        break;
                    case ValidFields.ValidaEmail:
                        { return ValidarEmail(value, validationContext.DisplayName); }
                    case ValidFields.ValidaLogin:
                        { return ValidarLogin(value, validationContext.DisplayName); }
                    case ValidFields.ValidaSenha:
                        { return ValidarSenha(value, validationContext.DisplayName); }
                    case ValidFields.ValidaConfirmaSenha:
                        break;
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório");
        }
        private ValidationResult ValidarEmail(object value, string displayField)
        {
            var email = db.usuarios.FirstOrDefault(x => x.Email == value.ToString()); //verificar se já existe no banco
            if (email != null)
                return new ValidationResult($"O campo {displayField} já existe.");

            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (result && email == null) //&& email == null comparando o resultado com o banco
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarSenha(object value, string displayField)
        {
            if (value.ToString().Length < 8)
                return new ValidationResult($"O campo {displayField} não atingiu o mínimo de caracteres (8)");
            if (value.ToString().Length > 16)
                return new ValidationResult($"O campo {displayField} atingiu o máximo de caracteres (16)");
            return ValidationResult.Success;
        }
        private ValidationResult ValidarNome(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[aA-zZ]+((\s[aA-zZ]+)+)?$");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarLogin(object value, string displayField)
        {
            var login = db.usuarios.FirstOrDefault(x => x.Login == value.ToString());
            if (login != null)
                return new ValidationResult($"O campo {displayField} já existe.");

            bool result = Regex.IsMatch(value.ToString(), @"^[a-zA-Z0-9]+$");
            if (result && login == null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} deve conter apenas letras ou números.");
        }
        private ValidationResult ValidarCpfCnpj(object value, string displayField)
        {
            var cpfcnpj = db.usuarios.FirstOrDefault(x => x.CpfCnpj == value.ToString());
            if (cpfcnpj != null)
                return new ValidationResult($"O {displayField} já está cadastrado.");

            bool result = Regex.IsMatch(value.ToString(), @"^[a-zA-Z0-9]+$");
            if (result && cpfcnpj == null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} deve conter apenas letras ou números.");
        }
    }
}