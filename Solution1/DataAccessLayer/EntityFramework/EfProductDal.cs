using NtierProjectDataAccessLayer.Abstract;
using NtierProjectDataAccessLayer.Repositories;
using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierProjectDataAccessLayer.EntityFramework
{
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
    }
}
