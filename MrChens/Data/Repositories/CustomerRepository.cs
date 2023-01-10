using MrChens.Data.ORM.Context;
using MrChens.Data.Repositories.Converters;
using System.Data.Entity.Migrations;

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

        public void Add(Handlers.Models.Customer customer)
        {
            var dbCustomer = CustomerConverter.Convert(customer);

            _MrChensContext.Customers.Add(dbCustomer);
            _MrChensContext.SaveChanges();

        }
        public Handlers.Models.Customer GetById(int Id)
        {
            //FirstOrDefault loops through all entries in Table - Finds First Entry that matches or the Default Entry that matches 
            var dbCustomer = _MrChensContext.Customers.FirstOrDefault(x => x.CustomerId == Id);

            if (dbCustomer != null)
            {
                var customer = CustomerConverter.Convert(dbCustomer);

                return customer;

            }
            return new Handlers.Models.Customer();
        }
        public IEnumerable<Handlers.Models.Customer> GetAll()
        {
            var dbCustomerList = _MrChensContext.Customers.ToList();

            var customerList = new List<Handlers.Models.Customer>();

            foreach (var dbCustomer in dbCustomerList)
            {
                var customer = new Handlers.Models.Customer()
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


        public void Delete(int id)
        {
            var customer = _MrChensContext.Customers.Single(c=>c.CustomerId==id);
            _MrChensContext.Customers.Remove(customer);
            _MrChensContext.SaveChanges();
        }

        public void Update(Handlers.Models.Customer customer)
        {
            var dbCustomer = CustomerConverter.Convert(customer);
            _MrChensContext.Customers.AddOrUpdate(dbCustomer);
            _MrChensContext.SaveChanges();

        }
    }
}
