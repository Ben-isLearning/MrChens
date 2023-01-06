using MrChens.Data.Models;
using MrChens.Handlers.Models; 

namespace MrChens.Data.Repositories.Converters
{
    public static class CustomerConverter
    {
        public static Data.Models.Customer Convert(Handlers.Models.Customer customer)
        {
            return new Models.Customer()
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                LikesDishId = customer.LikesDishId,
                DislikesDishId = customer.DislikesDishId,
            };
        }

        public static Handlers.Models.Customer Convert(Data.Models.Customer customer)
        {
            return new Handlers.Models.Customer()
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                LikesDishId = customer.LikesDishId,
                DislikesDishId = customer.DislikesDishId,
            };
        }
    }
}
