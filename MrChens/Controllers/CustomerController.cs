﻿using Microsoft.AspNetCore.Mvc;
using MrChens.Handlers;
using MrChens.Handlers.Models;

namespace MrChens.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        private readonly ICustomerHandler _CustomerHandler;

        public CustomerController(ILogger<CustomerController> logger, ICustomerHandler customerHandler)
        {
            _logger = logger;
            _CustomerHandler = customerHandler;
        }




        [HttpPost]
        [Route("AddCustomer")]
        public string AddCustomer(Customer customer)
        {
            _CustomerHandler.Add(customer);
            return "Hello I Work";
        }

        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public Customer GetCustomerById(int id)
        {
            var result = _CustomerHandler.GetById(id);
            return result;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public IEnumerable<Customer> GetAll() 
        {
            var result = _CustomerHandler.GetAll();
            return result;
        }
    }
}