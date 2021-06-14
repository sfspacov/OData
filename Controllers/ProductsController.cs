using Microsoft.AspNet.OData;
using OData.Model;
using System.Collections.Generic;

namespace OData.Controllers
{
    public class ProductsController : ODataController
    {
        [EnableQuery]
        public List<Product> Get()
        {
            return products;
        }

        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                ID = 1,
                Name = "Car",
                Price = 25000
            },
            new Product()
            {
                ID = 2,
                Name = "PlayStation",
                Price = 2500
            },
            new Product()
            {
                ID = 3,
                Name = "Bread",
                Price = 1.5
            },
            new Product()
            {
                ID = 4,
                Name = "Notebook",
                Price = 5000
            },
            new Product()
            {
                ID = 5,
                Name = "Shoes",
                Price = 150
            },
        };

    }
}
