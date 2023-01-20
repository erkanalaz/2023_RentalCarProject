using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç başarıyla eklendi!";
        public static string CarAddedError = "Araç ekleme başarısız!";
        public static string CarDeleted = "Araç başarıyla silindi";
        public static string CarUpdated = "Araç başarıyla güncellendi";
        public static string CarListed = "Araç listelendi";

        public static string MaintenanceTime = "Sistem bakımda, daha sonra tekrar deneyiniz!";

        public static string UserListed = "Kullanıcılar listelendi!";
        public static string UserAdded = "Kullanıcı eklendi!";
        public static string UserDeleted = "Kullanıcı silindi!";
        public static string UserUpdated = "Kullanıcı bilgisi güncellendi!";

        public static string InvalidPassword = "Hatalı parola girildi!";
        
        public static string BrandAdded = "Araç markası eklendi!";
        public static string BrandDeleted ="Araç markası silindi" ;
        public static string BrandUpdated = "Araç markası güncellendi";

        public static string ColorAdded = "Renk eklendi!";
        public static string ColorDeleted = "Renk silindi!";
        public static string ColorListed = "Renk listelendi!";
        public static string ColorUpdated = "Renk güncellendi!";

        public static string CustomerListed = "Müşteri listelendi!";
        public static string CustomerAdded = "Müşteri eklendi!";
        public static string CustomerDeleted = "Müşteri silindi!";
        public static string CustomerUpdated = "Müşteri güncellendi!";

        public static string RentalListed = "Kiralama listelendi!";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi!";
        public static string RentalUpdated = "Kiralama güncellendi!";

        public static string RentalFailed = "Araç kiradan dönmediği için tekrar kiralanamaz!";

        public static string CarImageNumberExceed = "Araca ait fotoğraf sayısı maksimum 5 olabilir";

        public static string PicturesUploaded = "Resimler başarıyla yüklendi";
    }
}
