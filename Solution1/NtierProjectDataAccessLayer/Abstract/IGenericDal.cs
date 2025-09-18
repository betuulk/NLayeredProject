using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierProjectDataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class  // sınıf harici başka bir bileşen gelemeyecek 
    {
        void Insert (T entity);
        void Update (T entity);
        void Delete (T entity);
        List<T> GetAll (); // tüm category türündeki verileri listeleyecek -- elektronik kategorsindeki ürünler
        T GetById (int id); // id → Aranan kaydın primary key değeridir. id’si 346 olan Customer tablosundaki kaydı döndürür.

  
    }
}
// merkezi bir sistem gibi kurgulanıyor 