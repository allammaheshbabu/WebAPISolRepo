using System.ComponentModel.DataAnnotations;

namespace WebAPIPro.CustomDataAnnotations
{
    public class DeptNoCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int val = Convert.ToInt32(value);
            if (val <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
