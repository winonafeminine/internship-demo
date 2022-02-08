using System.ComponentModel.DataAnnotations;

namespace internship_api.Models.user.route
{
    public class GetRoute : Route
    {
        [Required]
        public override string? Name { get; set; }
    }
}