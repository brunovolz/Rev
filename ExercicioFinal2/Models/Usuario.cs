using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioFinal2.Models
{
    public class Usuario : UserControls
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public long CpfCnpj { get; set; }
        public string NomeFantasia { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}