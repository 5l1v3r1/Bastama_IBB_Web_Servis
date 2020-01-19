using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bastama_İBB_Web_Servis
{
    public class İettGlobalApi
    {
        #region WebServis Tanımlamaları
        iett.WebService1SoapClient iettrequest = new iett.WebService1SoapClient();
        iettduyurular.DuyurularSoapClient iettduyururequest = new iettduyurular.DuyurularSoapClient();
        iettanlikveri.SeferGerceklesmeSoapClient iettanlikverirequest = new iettanlikveri.SeferGerceklesmeSoapClient();
        #endregion

        #region ListTanımlamaları
        public class durakbilgileri
        {
            public string SDURAKKODU { get; set; }
            public string SDURAKADI { get; set; }
            public string KOORDINAT { get; set; }
            public string ILCEADI { get; set; }
            public string SYON { get; set; }
            public string AKILLI { get; set; }
            public string FIZIKI { get; set; }
            public string DURAK_TIPI { get; set; }
        }
        public class garajbilgileri
        {
            public string İD { get; set; }
            public string GARAJADI { get; set; }
            public string GARAJKODU { get; set; }
            public string KOORDİNATI { get; set; }
        }
        public class duyurular
        {
            public string HAT { get; set; }
            public string TİP { get; set; }
            public string GUNCELLEMESAATİ { get; set; }
            public string MESAJ { get; set; }
        }
        public class bozukSatih
        {
            public string NMESAJID { get; set; }
            public string SKAPINUMARASI { get; set; }
            public string SSOFORSICILNO { get; set; }
            public string SMESAJMETNI { get; set; }
            public string DTKAYITZAMANI { get; set; }
            public string NBOYLAM { get; set; }
            public string NENLEM { get; set; }
        }
        public class filoarackonum
        {
            public string Operator { get; set; }
            public string Garaj { get; set; }
            public string KapiNo { get; set; }
            public string Saat { get; set; }
            public string Boylam { get; set; }
            public string Enlem { get; set; }
            public string Hiz { get; set; }
            public string Plaka { get; set; }
        }
        public class kazalokasyon
        {
            public string DTOLAYBASLANGICZAMANI { get; set; }
            public string NBOYLAM { get; set; }
            public string NENLEM { get; set; }
            public string Tur { get; set; }
        }
        #endregion

        #region GlobalMetodlar
        public void DurakBilgileri(DataGridView dt)
        {
            var json = iettrequest.GetDurak_json("");
            var result = JsonConvert.DeserializeObject<List<durakbilgileri>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "DURAKKODU";
            dt.Columns[1].HeaderText = "DURAKADI";
            dt.Columns[2].HeaderText = "KOORDINAT";
            dt.Columns[3].HeaderText = "ILÇE ADI";
            dt.Columns[4].HeaderText = "YÖNÜ";
            dt.Columns[5].HeaderText = "AKILLI";
            dt.Columns[6].HeaderText = "FIZIKI";
            dt.Columns[7].HeaderText = "DURAK TIPI";
        }
        public void DurakBilgileri(string DurakKodu, DataGridView dt)
        {
            var json = iettrequest.GetDurak_json(DurakKodu);
            var result = JsonConvert.DeserializeObject<List<durakbilgileri>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "DURAKKODU";
            dt.Columns[1].HeaderText = "DURAKADI";
            dt.Columns[2].HeaderText = "KOORDINAT";
            dt.Columns[3].HeaderText = "ILÇE ADI";
            dt.Columns[4].HeaderText = "YÖNÜ";
            dt.Columns[5].HeaderText = "AKILLI";
            dt.Columns[6].HeaderText = "FIZIKI";
            dt.Columns[7].HeaderText = "DURAK TIPI";
        }
        public void GarajBilgileri(DataGridView dt)
        {
            var json = iettrequest.GetGaraj_json();
            var result = JsonConvert.DeserializeObject<List<durakbilgileri>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "İD";
            dt.Columns[1].HeaderText = "GARAJ ADI";
            dt.Columns[2].HeaderText = "GARAJ KODU";
            dt.Columns[3].HeaderText = "KOORDİNATI";

        }
        public void Duyurular(DataGridView dt)
        {
            var json = iettduyururequest.GetDuyurular_json();
            var result = JsonConvert.DeserializeObject<List<duyurular>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "HAT";
            dt.Columns[1].HeaderText = "TİP";
            dt.Columns[2].HeaderText = "GUNCELLEME SAATİ";
            dt.Columns[3].HeaderText = "MESAJ";

        }
        public void BozukSatih(DataGridView dt,int saat)
        {
            var json = iettanlikverirequest.GetBozukSatih_json(saat);
            var result = JsonConvert.DeserializeObject<List<bozukSatih>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "MESAJ ID";
            dt.Columns[1].HeaderText = "KAPI NUMARASI";
            dt.Columns[2].HeaderText = "SOFOR SICIL NO";
            dt.Columns[3].HeaderText = "MESAJ METNI";
            dt.Columns[4].HeaderText = "KAYIT ZAMANI";
            dt.Columns[5].HeaderText = "BOYLAM";
            dt.Columns[6].HeaderText = "ENLEM";


        }
        public void FiloAracKonum(DataGridView dt)
        {
            var json = iettanlikverirequest.GetFiloAracKonum_json();
            var result = JsonConvert.DeserializeObject<List<filoarackonum>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "Operator";
            dt.Columns[1].HeaderText = "Garaj";
            dt.Columns[2].HeaderText = "KapiNo";
            dt.Columns[3].HeaderText = "Saat";
            dt.Columns[4].HeaderText = "Boylam";
            dt.Columns[5].HeaderText = "Enlem";
            dt.Columns[6].HeaderText = "Hiz";
            dt.Columns[7].HeaderText = "Plaka";


        }
        public void KazaLokasyon(DataGridView dt,string Tarih)
        {
            var json = iettanlikverirequest.GetKazaLokasyon_json(Tarih);
            var result = JsonConvert.DeserializeObject<List<kazalokasyon>>(json);
            dt.DataSource = result;
            dt.Columns[0].HeaderText = "BASLANGIC ZAMANI";
            dt.Columns[1].HeaderText = "BOYLAM";
            dt.Columns[2].HeaderText = "ENLEM";
            dt.Columns[3].HeaderText = "Tur";
        }
        #endregion
    }
}
