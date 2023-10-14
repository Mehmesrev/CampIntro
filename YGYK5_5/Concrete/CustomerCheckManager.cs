using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using YGYK5_5.Abstract;
using YGYK5_5.Entities;

namespace YGYK5_5.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)  
        {   
            if (customer.DateOfBirth == "2005" && customer.FirstName == "Mehmet" && customer.LastName == "V" && customer.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }      
    }
}
