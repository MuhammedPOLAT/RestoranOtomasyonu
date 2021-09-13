/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Collections.Generic;
using System.Text;
//Veritabanına bağlanmak için genel bir class sınıf oluşturdum.
namespace restoran
{
    class cGenel
    {
        public string conString = ("Server=X;Database=Restoran;Trusted_Connection=true");

        public static int _personelId;
        public static int _gorevId;
        public static int _musteriEkleme;
        public static string _ButtonValue;
        public static int _musteriId;
        public static string _ButtonName;
        public static int _servisTurNo;
        public static string _adisyonId;
    }
}
