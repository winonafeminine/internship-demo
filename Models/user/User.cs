using System.ComponentModel.DataAnnotations.Schema;

namespace internship_api.Models.user
{
    public class User : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? LastName { get; set; }
    }
}