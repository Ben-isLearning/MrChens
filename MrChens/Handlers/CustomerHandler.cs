using MrChens.Data.Repositories;
using MrChens.Handlers.Models;

namespace MrChens.Handlers
{
    public class CustomerHandler : ICustomerHandler
    {
        private readonly ICustomerRepository _CustomerRepository;
        public CustomerHandler(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _CustomerRepository.Add(customer);
        }

        public int addTwo(int input) {
            return input + 2;
        } 

    }
}
