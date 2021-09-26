using DipFramework.Core.DataAccess;
using DipFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipFramework.DataAccess.EntityFramework.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
