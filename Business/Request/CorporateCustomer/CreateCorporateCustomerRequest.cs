﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public  class CreateCorporateCustomerRequest
    {

        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }

    }
}
