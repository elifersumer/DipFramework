using DipFramework.Business.Abstract;
using DipFramework.Business.Concrete.Managers;
using DipFramework.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DipFramework.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var model = new ProductListViewModel { 
                 Products=_productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryId = 5,
                ProductName = "Laptop",
                UnitPrice = 12,
                QuantityPerUnit="8 oz",
                ReorderLevel=0,
                UnitsInStock=0,
                UnitsOnOrder=0
            });

            return "Added";
        }
    }

  
}
