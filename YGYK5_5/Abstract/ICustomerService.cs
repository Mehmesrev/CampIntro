﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGYK5_5.Entities;

namespace YGYK5_5.Abstract
{
    public interface ICustomerService
    {
        public void Add(Customer customer);

        public void Delete(Customer customer);

        public void Update(Customer customer);
    }

}
