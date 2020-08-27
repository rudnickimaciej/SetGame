﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Addresses
{
    public class Address
    {
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
    }
}