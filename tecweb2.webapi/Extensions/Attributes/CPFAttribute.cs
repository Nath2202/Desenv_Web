using System.ComponentModel.DataAnnotations;

namespace tecweb2.webapi.Extensions.Attributes
{
    public class CPFAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            if (value.ToString().Length == 0)
                return false;
            
            return Validadors.IsCPFValid(value.ToString());
        }

        public override string FormatErrorMessage(string name)
        {
            return "Esse CPF não é válido.";
        }
    }
}