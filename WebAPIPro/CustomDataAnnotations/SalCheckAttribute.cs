using System.ComponentModel.DataAnnotations;

namespace WebAPIPro.CustomDataAnnotations
{
    public class SalCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int sal= Convert.ToInt32(value);
            if(sal%10==0)
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
