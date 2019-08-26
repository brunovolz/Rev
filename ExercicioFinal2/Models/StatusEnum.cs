using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioFinal2.Models
{
    public class StatusEnum :System.Attribute
    {
        private string _value;
        public StatusEnum(string value)
        {
            _value = value;
        }
        public string Value
        {
            get { return _value; }
        }
    }
}