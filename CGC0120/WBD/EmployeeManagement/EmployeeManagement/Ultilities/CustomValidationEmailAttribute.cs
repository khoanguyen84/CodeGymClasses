using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Ultilities
{
    public class CustomValidationEmailAttribute : ValidationAttribute
    {
        private readonly string domainName;

        public CustomValidationEmailAttribute(string domainName)
        {
            this.domainName = domainName;
        }
        public override bool IsValid(object value)
        {
            return value.ToString().Split('@')[1].ToUpper() == domainName.ToUpper();
        }
    }
}
