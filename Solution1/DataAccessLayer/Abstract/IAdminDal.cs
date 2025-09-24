using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierProjectDataAccessLayer.Abstract
{
    public interface IAdminDal:IGenericDal<Admin>
    {
    }
}
// bu sınıflara ait interfaceler ile bağımlılığı azaltmış oluyoruz 