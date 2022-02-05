using System.ComponentModel.DataAnnotations;

namespace internship_api.Models.locations.thLocation.param
{
    public class GetParam : Param
    {
        [Required]
        public override int Limit { get; set; }
        // public virtual string Name { get; set; } = null!;
    }
}