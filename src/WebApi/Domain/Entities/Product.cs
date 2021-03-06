﻿using System;

namespace WebApi.Domain.Entities
{
    public class Product
    {
        public Product()
        {
        }

        public Product(Guid id, string name, string eanCode, decimal price)
        {
            Id = id;
            Name = name;
            EanCode = eanCode;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EanCode { get; set; }
        public decimal Price { get; set; }
        
        public override bool Equals(object obj)
        {
            var other = obj as Product;
            return other != null && (other.Id.Equals(Id));
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}