# Bastama_IBB_Web_Servis
   # Kullanımı
 
    using System;
    using System.Windows.Forms;
    using Bastama_İBB_Web_Servis;

    namespace İETT_HAT_DURAK_GÜZERGÂH_WEB_SERVİSİ
    {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void veriGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource= İettGlobalApi.DBozukSatih(22);
            
            İettGlobalApi.FiloAracKonum(dataGridView1);

            İettGlobalApi.BozukSatih(dataGridView1, 15);

            İettGlobalApi.DurakBilgileri("", dataGridView1);

            İettGlobalApi.DurakBilgileri("25255", dataGridView1);

            İettGlobalApi.Duyurular(dataGridView1);

            İettGlobalApi.GarajBilgileri(dataGridView1);

            İettGlobalApi.KazaLokasyon(dataGridView1, "2020/01/19"); 
        }
      }
    }

 
 # nuget Kurulum
     
     Install-Package EbubekirBastama.IBBWebServis -Version 1.0.0.1
 
 # app.config Edit
  
  app.config'i aşağıdaki kodlarla değiştirin.
   
    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
    <system.serviceModel>
    <bindings>
      <basicHttpBinding>
        <binding name="WebService1Soap" maxReceivedMessageSize="2147483647">
          <security mode="Transport" />
        </binding>
        <binding name="WebService1Soap1" maxReceivedMessageSize="2147483647" />
        <binding name="DuyurularSoap" maxReceivedMessageSize="2147483647">
          <security mode="Transport" />
        </binding>
        <binding name="DuyurularSoap1" maxReceivedMessageSize="2147483647" />
        <binding name="SeferGerceklesmeSoap" maxReceivedMessageSize="2147483647">
          <security mode="Transport" />
        </binding>
        <binding name="SeferGerceklesmeSoap1" maxReceivedMessageSize="2147483647" />
        <binding name="ibbSoap">
          <security mode="Transport" />
        </binding>
        <binding name="ibbSoap1" />
      </basicHttpBinding>
    </bindings>
    <client>
      <endpoint address="https://api.ibb.gov.tr/iett/UlasimAnaVeri/HatDurakGuzergah.asmx"
          binding="basicHttpBinding" bindingConfiguration="WebService1Soap"
          contract="iett.WebService1Soap" name="WebService1Soap" />
      <endpoint address="https://api.ibb.gov.tr/iett/UlasimDinamikVeri/Duyurular.asmx"
          binding="basicHttpBinding" bindingConfiguration="DuyurularSoap"
          contract="iettduyurular.DuyurularSoap" name="DuyurularSoap" />
      <endpoint address="https://api.ibb.gov.tr/iett/FiloDurum/SeferGerceklesme.asmx"
          binding="basicHttpBinding" bindingConfiguration="SeferGerceklesmeSoap"
          contract="iettanlikveri.SeferGerceklesmeSoap" name="SeferGerceklesmeSoap" />
      <endpoint address="https://api.ibb.gov.tr/iett/ibb/ibb.asmx"
          binding="basicHttpBinding" bindingConfiguration="ibbSoap"
          contract="iettcrm.ibbSoap" name="ibbSoap" />
      </client>
     </system.serviceModel>
    </configuration>

Ücretli Destek ve Bağış Yapmak için
Whatshapp : https://api.whatsapp.com/send?phone=905554128854&text=Merhaba

Phone : 905554128854

Bizlere Destek Olmak için: Bu proje gibi projelerin gelmesi ve bizlere destek olmak için bağış yapabilirsiniz. You can donate to come to projects like this project and support us.

                                             Kuvettürk İban Number
                                          ------------------------------
                                           TR40 0020 5000 0939 0747 4000 01
