using DipFramework.Core.DataAccess.EntityFramework;
using DipFramework.DataAccess.EntityFramework.Abstract;
using DipFramework.DataAccess.EntityFramework.Contexts;
using DipFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipFramework.DataAccess.EntityFramework.Concrete
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
