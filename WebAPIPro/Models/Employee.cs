using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebAPIPro.CustomDataAnnotations;

namespace WebAPIPro.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpId { set ; get ;}

        [Required(ErrorMessage ="please enter name....")]
        [StringLength(20,ErrorMessage ="pleease enter 20 chars....")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage="accepts only  alpha characters.......")]
        public string EmpName { set ; get ; }

        [Required(ErrorMessage = "please enter Gender......")]
        public string Gender { set ; get ; }

        [Required(ErrorMessage = "please enter Password....")]
        [PasswordCheck(ErrorMessage ="please provide the password must be more than 8 char and less than 16 ")]
        public string password { set; get; }


        [Required(ErrorMessage = "please enter Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="please enter proper email format....")]
        public string Email { set; get; }

        [Required(ErrorMessage = "please enter Phone")]
        [StringLength(10, ErrorMessage ="phone number must be 10 digits")]
        [RegularExpression(@"^(\+[0-9])$", ErrorMessage = "accepts only  numbers.......")]
        public string Phone { set ; get; }

        [Required(ErrorMessage = "please enter Salary")]
        [Range(5000,50000,ErrorMessage ="salary must be b/w 5000 and 50000 only.....")]
        [SalCheck(ErrorMessage ="salary should be divisible by 10.....")]
        public decimal salary { set ; get; }

        [Required(ErrorMessage = "please enter Address")]

        public string Address { set ; get; }

        [Required(ErrorMessage = "please enter DepNo")]
       

        [ForeignKey("Department")]
        public int DepNo { set ; get; }

        public Department? Department { set; get; }

    }
}
