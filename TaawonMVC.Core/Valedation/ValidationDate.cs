using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Valedation
{
    [AttributeUsage(AttributeTargets.Property |
     AttributeTargets.Field, AllowMultiple = false)]
    sealed class ValidationDate : ValidationAttribute 
    {
        public ValidationDate()
        {
            
        }

        public override bool IsValid(object value)
        {
            bool result = true;
            // Add validation logic here.
            return result;
        }
    }
}
