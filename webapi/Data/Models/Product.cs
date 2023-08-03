using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace webapi.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = null!;

        [Required]
        public string ProductDescription { get; set; } = null!;

        [Required]
        public string ProductImage { get; set; } = null!;

        [Required]
        public int ProductPrice { get; set; }

        [Required]
        public int ProductQuantity { get; set; }

        [Required]
        public int ProductRating { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [ForeignKey("Wishlist")]
        public int WishlistId { get; set; }

        public virtual Cart Cart { get; set; } = null!;

        public virtual Wishlist Wishlist { get; set; } = null!;

        public virtual ICollection<Feedback>? Feedback { get; set; }
    }
}
