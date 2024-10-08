using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Routing;

namespace WebAPIPro.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DepNo { get; set; }
        public string DepName { get; set; }

        public string Location { get; set; }

        public ICollection<Employee>? Employee { get; set; }
    }

}
