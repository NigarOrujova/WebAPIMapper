using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp2.DTOs
{
    public class ProductPostDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
