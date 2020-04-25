using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEntity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImagePath { get; set; }
    }
}
