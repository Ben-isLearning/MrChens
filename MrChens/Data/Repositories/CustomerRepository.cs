using MrChens.Data.ORM.Context;
using MrChens.Handlers.Models;

namespace MrChens.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        //CRUD functionality goes here
        private readonly IMrChensContext _MrChensContext;
        public CustomerRepository(IMrChensContext mrChensContext)
        {
            _MrChensContext = mrChensContext;
        }

        public void Add(Customer customer)
        {
            var dbCustomer = new Data.Models.Customer() {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                LikesDishId= customer.LikesDishId,
                DislikesDishId= customer.DislikesDishId,    
            };

            _MrChensContext.Customers.Add(dbCustomer);
            _MrChensContext.SaveChanges();

            //throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
