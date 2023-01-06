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
            var dbCustomer = new Data.Models.Customer()
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                LikesDishId = customer.LikesDishId,
                DislikesDishId = customer.DislikesDishId,
            };

            _MrChensContext.Customers.Add(dbCustomer);
            _MrChensContext.SaveChanges();

        }
        public Customer GetById(int Id)
        {
            //FirstOrDefault loops through all entries in Table - Finds First Entry that matches or the Default Entry that matches 
            var dbCustomer = _MrChensContext.Customers.FirstOrDefault(x => x.CustomerId == Id);

            if (dbCustomer != null)
            {

                var customer = new Handlers.Models.Customer()
                {
                    CustomerId = dbCustomer.CustomerId,
                    Name = dbCustomer.Name,
                    LikesDishId = dbCustomer.LikesDishId,
                    DislikesDishId = dbCustomer.DislikesDishId,
                };

                return customer;

            }
            return new Customer();
        }
        public IEnumerable<Customer> GetAll()
        {
            var dbCustomerList = _MrChensContext.Customers.ToList();

            var customerList = new List<Customer>();

            foreach (var dbCustomer in dbCustomerList)
            {
                var customer = new Customer()
                {
                    CustomerId = dbCustomer.CustomerId,
                    Name = dbCustomer.Name,
                    LikesDishId = dbCustomer.LikesDishId,
                    DislikesDishId = dbCustomer.DislikesDishId,
                };

                customerList.Add(customer);
            }

            return customerList;
            //throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            var customer = GetById(Id);

            if (customer.CustomerId != 0)
            {
                var dbCustomer = new Data.Models.Customer()
                {
                    CustomerId = customer.CustomerId,
                    Name = customer.Name,
                    LikesDishId = customer.LikesDishId,
                    DislikesDishId = customer.DislikesDishId,
                };
                _MrChensContext.Customers.Remove(dbCustomer);
            }

        }



        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
