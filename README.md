# Bastama_IBB_Web_Servis
 # Kullanımı
 
 # nuget Kurulum
 
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
