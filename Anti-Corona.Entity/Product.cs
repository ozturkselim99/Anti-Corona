﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Anti_Corona.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } //git deneme

        public string Title  { get; set; }

        public string Description { get; set; }
        public double? Price { get; set; }
        public int Stock { get; set; }
        public bool IsHomePage { get; set; }
        public bool IsOnSale { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; } 

    }
}
