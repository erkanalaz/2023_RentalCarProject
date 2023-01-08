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
    }
}
