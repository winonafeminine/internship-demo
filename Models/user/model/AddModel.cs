using System.ComponentModel.DataAnnotations;

namespace internship_api.Models.user.model
{
    public class AddModel : UserModel 
    {
        [Required]
        public override string? Name { get; set; }

        [Required]
        public override string? LastName { get; set; }
    }
}