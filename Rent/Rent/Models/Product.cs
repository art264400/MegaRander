using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rent.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsReserved { get; set; }
        public bool IsTaken { get; set; }
        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}