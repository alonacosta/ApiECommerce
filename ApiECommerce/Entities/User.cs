using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiECommerce.Entities
{
    public class User
    {
        public int Id { get; set; }

        //[Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(150)]
        public string? Email { get; set; }

        [Required]
        [StringLength(100)]
        public string? Password { get; set; }

        [StringLength(100)]
        public string? UrlImage { get; set; }

        [StringLength(80)]
        public string? Phone { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
