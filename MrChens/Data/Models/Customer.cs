using System.ComponentModel.DataAnnotations;
namespace MrChens.Data.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int LikesDishId { get; set; }
        public int DislikesDishId { get; set; }

    }
}