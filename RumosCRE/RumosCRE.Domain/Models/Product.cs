﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RumosCRE.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
