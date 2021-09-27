using DipFramework.Business.Concrete.Managers;
using DipFramework.DataAccess.EntityFramework.Abstract;
using DipFramework.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipFramework.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);


            Assert.ThrowsException<ValidationException>(()=>productManager.Add(new Product()));
        }
    }
}
