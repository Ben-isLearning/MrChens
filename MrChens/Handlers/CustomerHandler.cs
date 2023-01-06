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

        public Customer GetById(int id)
        {
            var result = _CustomerRepository.GetById(id);
            return result;  

        }

        public IEnumerable<Customer> GetAll() 
        {
            var result = _CustomerRepository.GetAll();
            return result;
        }

        public void Delete(int id) 
        { 
           _CustomerRepository.Delete(id);
        }

        public void Update(Customer customer) 
        {
            _CustomerRepository.Update(customer);  
        }

        public int addTwo(int input) {
            return input + 2;
        } 

    }
}
