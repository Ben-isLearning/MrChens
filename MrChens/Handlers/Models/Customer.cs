namespace MrChens.Handlers.Models
{
    public class Customer
    {
        public Customer(int customerId, string name, int likesDishId, int dislikesDishId)
        {
            CustomerId = customerId;
            Name = name;
            LikesDishId = likesDishId;
            DislikesDishId = dislikesDishId;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int LikesDishId { get; set; }
        public int DislikesDishId { get; set; }

    }
}