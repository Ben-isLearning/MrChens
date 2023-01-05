using MrChens.Handlers.Models;

namespace MrChens.Data.Repositories
{
    public interface ICustomerRepository
    {
        public void Add(Customer customer); 
        public void Update(Customer customer);
        public void Delete(int Id);
        public IEnumerable<Customer> GetAll();
        public Customer GetById(int Id);
    }
}
