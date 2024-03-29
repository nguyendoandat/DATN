﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Product
    {
        public Product()
        {

            Reviews = new HashSet<Reviews>();
            Medias = new HashSet<Medias>();

        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public string ProductDetail { get; set; }
        public decimal Price { get; set; }
        public bool Trend { get; set; }
        public bool Status { get; set; }
        public int View { get; set; }
        public string Thumb { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ImportProductId { get; set; }
        public ImportProduct ImportProduct { get; set; }
        public int ImportId { get; set; }
        public Import Import { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Medias> Medias { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
