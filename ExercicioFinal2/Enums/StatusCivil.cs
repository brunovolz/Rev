using ExercicioFinal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioFinal2.Enums
{
    public enum StatusCivil
    {
        [StatusEnum("Solteiro")]
        Solteiro = 0,
        [StatusEnum("Amasiado")]
        Amasiado = 1,
        [StatusEnum("União Estável")]
        UniaoEstavel = 2,
        [StatusEnum("Casado")]
        Casado = 3,
        [StatusEnum("Viúvo")]
        Viuvo = 4,
        [StatusEnum("Divorciado")]
        Divorciado = 5
          
    }
}