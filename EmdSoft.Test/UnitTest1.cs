using System;
using System.Linq;
using System.Net.Mime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System.Collections.Generic;
using System.Collections;
using System.Data.Entity;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
namespace EmdSoft.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new NetSatisContext();
            var stokDal = new StokDAL();
            var stok = stokDal.GetAll(context, x => x.StokHareket.Count > 5 && x.StokHareket.Any(c => c.SatisFiyati>0 && (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") ||
                                                                                                      (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1"))).FirstOrDefault();
            var res = stok.StokHareket.ToList();
            var sonuc = res.Count() / res.Sum(c => c.SatisFiyati);
            Console.WriteLine(stok.StokAdi + " için Stok çıkış ortalama fiyat hesaplama");
            Console.WriteLine("Adet=>" + stok.StokHareket.Count);
            Console.WriteLine("Satış fiyatı=>"+res.Sum(c => c.SatisFiyati));
            Console.WriteLine("Sonuç=>" + sonuc);
            Assert.IsTrue(res.Count() > 0);
            Assert.IsTrue(res.Sum(c => c.SatisFiyati) > 0);
        }
    }
}
