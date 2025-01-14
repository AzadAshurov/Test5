using System.ComponentModel.DataAnnotations;

namespace Testgithub2.Areas.Admin.ViewModels.Professions
{
    public class CreateProfessionVM
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
