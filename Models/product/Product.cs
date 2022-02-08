using System.ComponentModel.DataAnnotations.Schema;

namespace internship_api.Models.product
{
    public class Product : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
    }
}