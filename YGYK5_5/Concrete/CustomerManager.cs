using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGYK5_5.Abstract;
using YGYK5_5.Entities;

namespace YGYK5_5.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService userValidationService)
        {
            _customerCheckService = userValidationService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                Console.WriteLine("Added this customer: " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted this customer: " + customer.FirstName + " " + customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Updated this customer: " + customer.FirstName + " " + customer.LastName);
        }
    }
}
