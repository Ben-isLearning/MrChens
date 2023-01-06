using MrChens.Handlers.Models;

namespace MrChens.Handlers
{
    public interface ICustomerHandler
    {
        public void Add(Customer customer);
        public Customer GetById(int id);
        public IEnumerable<Customer> GetAll();
        public void Delete(int id);
        public void Update(Customer customer);
        public int addTwo(int input);

    }
}
