using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Data.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comment { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Client Client { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
    }
}
