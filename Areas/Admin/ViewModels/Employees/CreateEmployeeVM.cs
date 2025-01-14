using System.ComponentModel.DataAnnotations;

namespace Testgithub2.Areas.Admin.ViewModels.Employees
{
    public class CreateEmployeeVM
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
