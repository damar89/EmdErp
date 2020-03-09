﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSatis.EDonusum.Models
{
    public class Donusum
    {
        [Table("HareketTipi")]
        public class HareketTipi
        {
            [Key]
            public int Id { get; set; }
            public string Kodu { get; set; }
            public string Aciklama { get; set; }
        }
        [Table("FaturaBaslik")]
        public class Master
        {
            [Key]
            public int Id { get; set; }
            public string SeriKodu { get; set; }
            public string SiraKodu { get; set; }
            public string HarTip { get; set; }
            public string DokumanKodu { get; set; }
            public int AlisVerisNo { get; set; }
            public int MusteriKodu { get; set; }
            public int HareketTipi { get; set; }
            public string FisKodu { get; set; }
            public string Aciklama { get; set; }
            public DateTime IslemTarihi { get; set; }
            public DateTime VadeTarihi { get; set; }
            public string FisTuru { get; set; }
            public decimal Tutar { get; set; }
            public decimal Kdv { get; set; }
            public decimal DipIskonto { get; set; }
            public decimal Matrah { get; set; }
            public decimal NetTutar { get; set; }
            public DateTime SaveDate { get; set; }
            public int SaveUser { get; set; }
            public DateTime EditDate { get; set; }
            public int EditUser { get; set; }
        }
        [Table("FaturaDetay")]
        public class Details
        {
            [Key]
            public int Id { get; set; }
            public int MasterId { get; set; }
            public int MusteriKodu { get; set; }
            public int StokId { get; set; }
            public string Magaza { get; set; }
            public string HarTip { get; set; }
            public decimal Tutar { get; set; }
            public decimal Miktar { get; set; }
            public decimal Kdv { get; set; }
            public decimal KdvOrani { get; set; }
            public decimal KdvDahilFiyat { get; set; }
            public decimal Matrah { get; set; }
            public decimal IskontoTutar { get; set; }
            public decimal Isk1 { get; set; }
            public decimal Isk2 { get; set; }
            public decimal Isk3 { get; set; }
            public int HareketTipi { get; set; }
            public Guid TempId { get; set; }

        }
        public class MasterView
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string VergiNumarasi { get; set; }
            public string MusteriAdi { get; set; }
            public Master master { get; set; }
        }
    }
}
