using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace NetSatis.Reports.Fatura_ve_Fiş
{
    public class FaturaHazirla
    {
        public void FaturaHazirlama(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();
            var cariDal = new CariDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);

            //decimal? bakiye = cariDal.cariBakiyesi(context, Convert.ToInt32(fisBilgi.CariId))?.Bakiye;
            var bakiye = cariDal.cariBakiyesi(context, Convert.ToInt32(fisBilgi.CariId))?.Bakiye;

            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();

            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            //DTBilgiler.Columns.Add("FisIskontoOrani2", typeof(decimal));
            //DTBilgiler.Columns.Add("FisIskontoOrani3", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            //DTBilgiler.Columns.Add("FisIskontoTutari2", typeof(decimal));
            //DTBilgiler.Columns.Add("FisIskontoTutari3", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.Columns.Add("Bakiye", typeof(decimal));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.CariAdi + " " + fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama;
            row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            //row["FisIskontoOrani2"] = (decimal)fisBilgi.IskontoOrani2;
            //row["FisIskontoOrani3"] = (decimal)fisBilgi.IskontoOrani3;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            //row["FisIskontoTutari2"] = (decimal)fisBilgi.IskontoTutari2;
            //row["FisIskontoTutari3"] = (decimal)fisBilgi.IskontoTutari3;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            row["Bakiye"] = bakiye;
            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto3", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari3", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemIskonto2"] = (decimal)item.IndirimOrani2;
                f["KalemIskonto3"] = (decimal)item.IndirimOrani3;
                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                //f.KalemToplam
                if (fisBilgi.KDVDahil)
                {
                    f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;

                }
                f["KalemToplam"] = (decimal)item.AraToplam;
                f["KalemIndirimTutari"] = (decimal?)item.IndirimTutar;
                //f["KalemIndirimTutari2"] = (decimal?)item.IndirimTutar2;
                //f["KalemIndirimTutari3"] = (decimal?)item.IndirimTutar3;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion

            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);

            rptFaturaBarkodlu ftr = new rptFaturaBarkodlu();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.FaturaDizayn_DosyaYolu));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";

            ftr.ShowPreview();


        }
        public void TahsilatFisi(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);

            var cariDal = new CariDAL();
            var bakiye = cariDal.cariBakiyesi(context, Convert.ToInt32(fisBilgi.CariId))?.Bakiye;
            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();
            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.Columns.Add("Bakiye", typeof(decimal));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama;
            row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            row["Bakiye"] = bakiye;

            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                f["KalemToplam"] = (decimal)item.ToplamTutar;
                //if (fisBilgi.KDVDahil)
                //{
                //    f["KalemBirimFiyati"] = (decimal)item.KdvHaric_;

                //}

                f["KalemIndirimTutari"] = (decimal)item.IndirimTutar;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion
            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);
            rptTahsilat ftr = new rptTahsilat();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.TahsilatDizayn_DosyaYolu5));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";
            ftr.Print();

        }
        public void BilgiFisi(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);

            var cariDal = new CariDAL();
            var bakiye = cariDal.cariBakiyesi(context, Convert.ToInt32(fisBilgi.CariId))?.Bakiye;
            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();
            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.Columns.Add("Bakiye", typeof(decimal));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama;
            row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            row["Bakiye"] = bakiye;

            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                f["KalemToplam"] = (decimal)item.ToplamTutar;
                //if (fisBilgi.KDVDahil)
                //{
                //    f["KalemBirimFiyati"] = (decimal)item.KdvHaric_;

                //}

                f["KalemIndirimTutari"] = (decimal)item.IndirimTutar;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion
            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);
            rptBilgi ftr = new rptBilgi();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisiDizayn_DosyaYolu6));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";
            ftr.Print();

        }
        public void SiparisHazirlama(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);

            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();

            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama; row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskont2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskont3", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari3", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemIskonto2"] = (decimal)item.IndirimOrani2;
                f["KalemIskonto3"] = (decimal)item.IndirimOrani3;

                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                //f.KalemToplam
                if (fisBilgi.KDVDahil)
                {
                    f["KalemBirimFiyati"] = (decimal)item.KdvHaric_;

                }
                f["KalemToplam"] = (decimal)item.ToplamTutar;
                f["KalemIndirimTutari"] = (decimal)item.IndirimTutar;
                //f["KalemIndirimTutari2"] = (decimal)item.IndirimTutar2;
                //f["KalemIndirimTutari3"] = (decimal)item.IndirimTutar3;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion



            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);


            //DataTable DT = toDataTable4(liste);
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //  if (ofd.ShowDialog() == DialogResult.OK)
            //{
            rptSiparis ftr = new rptSiparis();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.SiparisDizayn_DosyaYolu1));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";
            //ftr.DetailReport.DataSource = DT;
            //ftr.DetailReport.DataMember = "Fatura1";
            //ftr.DetailReport1.DataSource = DT1;
            //ftr.DetailReport1.DataMember = "KDVLER";

            //ftr.BeginInit();                    
            //ftr.DataSource = DS;
            //ftr.DataMember = "Fatura1";                    //ftr.EndInit();                 
            ftr.ShowPreview();
            // }
            // }

        }

        public void TeklifHazirlama(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);


            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();


            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama;
            row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto3", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari3", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemIskonto2"] = (decimal)item.IndirimOrani2;
                f["KalemIskonto3"] = (decimal)item.IndirimOrani3;
                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                //f.KalemToplam
                if (fisBilgi.KDVDahil)
                {
                    f["KalemBirimFiyati"] = (decimal)item.KdvHaric_;

                }
                f["KalemToplam"] = (decimal)item.ToplamTutar;
                f["KalemIndirimTutari"] = (decimal)item.IndirimTutar;
                //f["KalemIndirimTutari2"] = (decimal)item.IndirimTutar2;
                //f["KalemIndirimTutari3"] = (decimal)item.IndirimTutar3;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion



            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);


            //DataTable DT = toDataTable4(liste);
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //  if (ofd.ShowDialog() == DialogResult.OK)
            //{
            rptTeklif ftr = new rptTeklif();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.TeklifDizayn_DosyaYolu2));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";
            //ftr.DetailReport.DataSource = DT;
            //ftr.DetailReport.DataMember = "Fatura1";
            //ftr.DetailReport1.DataSource = DT1;
            //ftr.DetailReport1.DataMember = "KDVLER";

            //ftr.BeginInit();                    
            //ftr.DataSource = DS;
            //ftr.DataMember = "Fatura1";                    
            //ftr.EndInit();                 
            ftr.ShowPreview();
            // }
            // }

        }
        public void IrsaliyeHazirlama(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);


            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();


            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama;
            row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto3", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari3", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemIskonto2"] = (decimal)item.IndirimOrani2;
                f["KalemIskonto3"] = (decimal)item.IndirimOrani3;
                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                //f.KalemToplam
                if (fisBilgi.KDVDahil)
                {
                    f["KalemBirimFiyati"] = (decimal)item.KdvHaric_;

                }
                f["KalemToplam"] = (decimal)item.ToplamTutar;
                f["KalemIndirimTutari"] = (decimal)item.IndirimTutar;
                //f["KalemIndirimTutari2"] = (decimal)item.IndirimTutar2;
                //f["KalemIndirimTutari3"] = (decimal)item.IndirimTutar3;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion



            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);



            rptIrsaliye ftr = new rptIrsaliye();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.IrsaliyeDizayn_DosyaYolu3));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";

            ftr.ShowPreview();


        }
        public void ProformaFaturaHazirlama(string FisKodu)
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == FisKodu);
            List<StokHareket> stokHareketleri = stokHareketDal.GetAll(context, c => c.FisKodu == FisKodu);


            Dictionary<int, decimal> KDVLer = new Dictionary<int, decimal>();


            #region FaturaBilgiler
            DataTable DTBilgiler = new DataTable();
            DTBilgiler.Columns.Add("CariAdiFaturaUnvan", typeof(string));
            DTBilgiler.Columns.Add("CariAdres", typeof(string));
            DTBilgiler.Columns.Add("CariVergiDairesi", typeof(string));
            DTBilgiler.Columns.Add("CariVergiNo", typeof(string));
            DTBilgiler.Columns.Add("FaturaTarihi", typeof(global::System.DateTime));
            DTBilgiler.Columns.Add("CariIkamet", typeof(string));
            DTBilgiler.Columns.Add("FisAraToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisKDVToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplam", typeof(decimal));
            DTBilgiler.Columns.Add("FisGenelToplamYazi", typeof(string));
            DTBilgiler.Columns.Add("FisAciklama", typeof(string));
            DTBilgiler.Columns.Add("FisIskontoOrani", typeof(decimal));
            DTBilgiler.Columns.Add("FisIskontoTutari", typeof(decimal));
            DTBilgiler.Columns.Add("FisKodu", typeof(string));
            DTBilgiler.Columns.Add("FisBelgeNo", typeof(string));
            DTBilgiler.Columns.Add("FisTuru", typeof(string));
            DTBilgiler.Columns.Add("FisCepTel", typeof(string));
            DTBilgiler.TableName = "FaturaBilgiler";
            DataRow row = DTBilgiler.NewRow();
            row["CariAdiFaturaUnvan"] = fisBilgi.FaturaUnvani;
            row["CariAdres"] = fisBilgi.Adres;
            row["CariIkamet"] = fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            row["CariVergiDairesi"] = fisBilgi.VergiDairesi;
            row["CariVergiNo"] = fisBilgi.VergiNo;
            row["FaturaTarihi"] = fisBilgi.Tarih;
            row["FisAciklama"] = fisBilgi.Aciklama;
            row["FisAraToplam"] = fisBilgi.AraToplam_;
            row["FisBelgeNo"] = fisBilgi.BelgeNo;
            row["FisCepTel"] = fisBilgi.CepTelefonu;
            row["FisGenelToplam"] = fisBilgi.ToplamTutar;
            row["FisGenelToplamYazi"] = yaziyaCevir((decimal)fisBilgi.ToplamTutar);
            row["FisIskontoOrani"] = (decimal)fisBilgi.IskontoOrani1;
            row["FisIskontoTutari"] = (decimal)fisBilgi.IskontoTutari1;
            row["FisKDVToplam"] = (decimal)fisBilgi.KdvToplam_;
            row["FisKodu"] = fisBilgi.FisKodu;
            row["FisTuru"] = fisBilgi.FisTuru;
            DTBilgiler.Rows.Add(row);
            #endregion

            #region Kalemler
            DataTable DTKalemler = new DataTable();
            DTKalemler.Columns.Add("KalemBarkod", typeof(string));
            DTKalemler.Columns.Add("KalemStokKodu", typeof(string));
            DTKalemler.Columns.Add("KalemStokAdi", typeof(string));
            DTKalemler.Columns.Add("KalemMiktar", typeof(decimal));
            DTKalemler.Columns.Add("KalemBirim", typeof(string));
            DTKalemler.Columns.Add("KalemBirimFiyati", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDV", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIskonto3", typeof(decimal));
            DTKalemler.Columns.Add("KalemToplam", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari2", typeof(decimal));
            DTKalemler.Columns.Add("KalemIndirimTutari3", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVTutari", typeof(decimal));
            DTKalemler.Columns.Add("KalemKDVliIndirimliToplam", typeof(string));
            DTKalemler.TableName = "FaturaKalemler";
            foreach (var item in stokHareketleri)
            {
                DataRow f = DTKalemler.NewRow();
                f["KalemBarkod"] = item.Stok.Barkodu;
                f["KalemBirim"] = item.Stok.Birim;
                f["KalemBirimFiyati"] = (decimal)item.BirimFiyati;
                f["KalemIskonto"] = (decimal)item.IndirimOrani;
                f["KalemIskonto2"] = (decimal)item.IndirimOrani3;
                f["KalemIskonto3"] = (decimal)item.IndirimOrani3;
                f["KalemKDV"] = item.Kdv;
                f["KalemMiktar"] = (decimal)item.Miktar;
                f["KalemStokAdi"] = item.Stok.StokAdi;
                f["KalemStokKodu"] = item.Stok.StokKodu;
                //f.KalemToplam
                if (fisBilgi.KDVDahil)
                {
                    f["KalemBirimFiyati"] = (decimal)item.KdvHaric_;

                }
                f["KalemToplam"] = (decimal)item.ToplamTutar;
                f["KalemIndirimTutari"] = (decimal)item.IndirimTutar;
                //f["KalemIndirimTutari2"] = (decimal)item.IndirimTutar2;
                //f["KalemIndirimTutari3"] = (decimal)item.IndirimTutar3;
                f["KalemKDVliIndirimliToplam"] = (decimal)item.KdvToplam;
                f["KalemKDVTutari"] = (decimal)item.KdvToplam;

                if (KDVLer.ContainsKey(item.Kdv))
                {
                    KDVLer[item.Kdv] += (decimal)item.KdvToplam;
                }
                else
                {
                    KDVLer.Add(item.Kdv, (decimal)item.KdvToplam);
                }

                DTKalemler.Rows.Add(f);
            }
            #endregion

            #region KDVler
            DataTable DTKDVler = new DataTable();
            DTKDVler.Columns.Add("KDV", typeof(int));
            DTKDVler.Columns.Add("Tutar", typeof(string));
            DTKDVler.TableName = "FaturaKDVler";
            foreach (var item in KDVLer)
            {
                DataRow dr = DTKDVler.NewRow();

                dr["KDV"] = item.Key.ToString();
                dr["Tutar"] = item.Value.ToString();

                DTKDVler.Rows.Add(dr);
            }
            #endregion



            DataSet DS = new DataSet("DataSEtler");
            DS.Tables.Add(DTBilgiler);
            DS.Tables.Add(DTKalemler);
            DS.Tables.Add(DTKDVler);



            rptProformaFatura ftr = new rptProformaFatura();
            ftr.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.ProFaturaDizayn_DosyaYolu4));
            ftr.DataSource = DS;
            ftr.DataMember = "FaturaBilgiler";

            ftr.ShowPreview();
            // }
            // }

        }



        string yaziyaCevir(decimal cevir)
        {
            string sTutar = cevir.ToString("F2").Replace('.', ',');
            string lira = sTutar.Substring(0, sTutar.IndexOf(','));
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor.
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor.
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "SIFIR Kr.";

            return yazi;

        }

        public DataTable toDataTable<T>(IEnumerable<T> Lnqlst)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Lnqlst == null) return dt;

            foreach (T Record in Lnqlst)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable toDataTable2<T>(IList<T> list)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                table.Rows.Add(values);
            }
            return table;
        }

        public DataTable toDataTable3<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public DataTable toDataTable4<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
