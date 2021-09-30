using DipFramework.Business.Abstract;
using DipFramework.Business.CrossCuttingConcerns.Validation.FluentValidation;
using DipFramework.Business.ValidationRules.FluentValidation;
using DipFramework.Core.Aspects.PostSharp;
using DipFramework.Core.Aspects.PostSharp.ValidationAspects;
using DipFramework.DataAccess.EntityFramework.Abstract;
using DipFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipFramework.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList().ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
