using MrChens.Handlers.Models;

namespace MrChens.Handlers
{
    public interface ICustomerHandler
    {
        public void Add(Customer customer);
        public Customer GetById(int id);

        public int addTwo(int input);

    }
}
