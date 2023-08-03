using System.ComponentModel.DataAnnotations;

namespace webapi.Data.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public virtual Client Client { get; set; } = null!;

        public virtual ICollection<Product>? Products { get; set; }
    }
}
