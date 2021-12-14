using ArchClass.Products.Contract;
using ArchClass.Products.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchClass.Products.Service
{
    public class ProductService : IProductService
    {
        private IEnumerable<Product> Products = new List<Product>();

        public ProductService()
        {

            var paulistaStore = "Paulista";
            var morumbiStore = "Morumbi";

            var beef = new Item { ItemId = Guid.NewGuid(), Name = "beef" };
            var pork = new Item { ItemId = Guid.NewGuid(), Name = "pork" };
            var mustard = new Item { ItemId = Guid.NewGuid(), Name = "mustard" };
            var ketchup = new Item { ItemId = Guid.NewGuid(), Name = "ketchup" };
            var bread = new Item { ItemId = Guid.NewGuid(), Name = "bread" };
            var wBread = new Item { ItemId = Guid.NewGuid(), Name = "whole bread" };

            Products = new List<Product>()
    {
        new Product { ProductId = Guid.NewGuid(), Name = "Darth Bacon",
            Image = "hamb1.png", StoreName = paulistaStore,
            Items = new List<Item> {beef, ketchup, bread }
        },
        new Product { ProductId = Guid.NewGuid(), Name = "Cap. Spork",
            Image = "hamb2.png", StoreName = paulistaStore,
            Items = new List<Item> { pork, mustard, wBread }
        },
        new Product { ProductId = Guid.NewGuid(), Name = "Beef Turner",
            Image = "hamb3.png", StoreName = morumbiStore,
            Items = new List<Item> {beef, mustard, bread }
        }
    };
        }

        public IEnumerable<Product> GetProductByStoreName(string storeName)
        {
            return Products.Where(product => product.StoreName == storeName);
        }
    }
}
