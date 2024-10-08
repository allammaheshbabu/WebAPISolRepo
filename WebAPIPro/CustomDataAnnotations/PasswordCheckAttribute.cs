using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebAPIPro.CustomDataAnnotations
{
    public class PasswordCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var pwd= Convert.ToString(value);
            if((pwd.Length >= 8)&&(pwd.Length <=16))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
           
       
    }

    
}
