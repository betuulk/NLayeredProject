using NtierProjectDataAccessLayer.Abstract;
using NtierProjectDataAccessLayer.Repositories;
using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///GenericRepository<Admin> → Generic repository’nin tüm temel metodlarını 
///(Add, Delete, Update, GetAll, GetById) otomatik olarak Admin için hazır hale getiriyor.
///Admin için “GetAdminsByRole(string role)” gibi özel bir sorgu yazılacağı zaman IAdminDal'a yazılır ve oradan miras alınır


namespace NtierProjectDataAccessLayer.EntityFramework
{
    public class EfAdminDal :GenericRepository<Admin>,IAdminDal 
    {
    }
}
