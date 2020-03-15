using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace eShopSolution.Data.Entities
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set;}
        public decimal Price { get; set; }
        public decimal Original { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }

    }
}
