﻿using NetSatis.Entities.Interface;
using System.Collections.Generic;

namespace NetSatis.Entities.Tables
{
    public class Depo : IEntity
    {
        public int Id { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string YetkiliKodu { get; set; }
        public string YetkiliAdi { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Aciklama { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }
        public virtual ICollection<StokHareket> StokHareket { get; set; }
    }
}
