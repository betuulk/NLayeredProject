using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierProjectDataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category> // Category sınıfı için update ınsert işlemleri hazır hale geliyor
    {
    }
}
