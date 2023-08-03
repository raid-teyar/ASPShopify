using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Data.Models
{
    public class Client : User
    {
        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [ForeignKey("Wishlist")]
        public int WishlistId { get; set; }

        public virtual Cart Cart { get; set; } = null!;

        public virtual Wishlist Wishlist { get; set; } = null!;

        public virtual ICollection<Feedback>? Feedback { get; set; }
    }
}
