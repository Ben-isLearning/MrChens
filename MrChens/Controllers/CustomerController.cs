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
        public string AddCustomer(Customer customer)
        {

            _CustomerHandler.Add(customer);
            return "Hello I Work";
        }
    }
}