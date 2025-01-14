using System.ComponentModel.DataAnnotations;

namespace Testgithub2.Areas.Admin.ViewModels.Professions
{
    public class GetProfessionVM
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
