using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class FaturaDataModel
    {
        public string CariAdiFaturaUnvan;
        public string CariAdres;
        public string CariVergiDairesi;
        public string CariVergiNo;
        public System.DateTime FaturaTarihi;
        public string CariIkamet;
        public string KalemBarkod;
        public string KalemStokKodu;
        public string KalemStokAdi;
        public decimal KalemMiktar;
        public string KalemBirim;
        public decimal KalemBirimFiyati;
        public decimal KalemKDV;
        public decimal KalemIskonto;
        public decimal KalemIskonto2;
        public decimal KalemIskonto3;
        public decimal FisAraToplam;
        public decimal FisKDVToplam;
        public decimal FisGenelToplam;
        public decimal FisIndirimTutari;
        public string FisGenelToplamYazi;
        public decimal KalemToplam;
        public string FisAciklama;
        public decimal FisIskontoOrani;
        public decimal FisIskontoTutari;
        public string FisKodu;
        public string FisBelgeNo;
        public string FisTuru;
        public string FisCepTel;
        public decimal KalemIndirimTutari;
        public decimal KalemKDVTutari;
        public decimal KalemKDVliIndirimliToplam;
    }
}
