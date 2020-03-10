using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace NetSatis.Entities.Tools
{
    public static class ExtendedFunctions
    {
        public static void BarkodEkle (this GridView grid, GridColumn barkodColumn)
        {
            string BarkodBilgisi = SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodAyarlari_Barkodu);

            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BarkodAyarlari_Barkodu, Convert.ToString(Convert.ToInt32(BarkodBilgisi) + 1));
            SettingsTool.Save();

            var Kod = CodeTool.Barkodulustur("2222", SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodAyarlari_Barkodu));

            //var kaynakListesi = grid.DataController.ListSource.Cast<Barkod>().ToList();

            //var yeniBarkod = new Barkod {Barkodu = Kod};

            grid.AddNewRow();
            grid.SetFocusedRowCellValue(barkodColumn, Kod);
            grid.UpdateCurrentRow();

            //kaynakListesi.Add(yeniBarkod);
            //grid.GridControl.RefreshDataSource();
        }
    }
}
