using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarInvalid= "Arabanın adı 2 harften küçükse ve fiyatı 0 dan küçükse eklenemez.";
        public static string CarDeleted="Araba silindi";
        public static string CarUpdated="Araba bilgileri guncellendi";
        public static string MaintenanceTime="Bakım saati";
        public static string CarListed="Arabalar Listelendi";
        public static string BrandAdded="Marka Eklendi";
        public static string BrandDeleted="Marka Silindi";
        public static string BrandUpdated="Marka bilgisi güncellendi";
        public static string ColorUpdated="Araba rengi güncellendi";
        public static string ColorDeleted="Araba rengi Silindi";
        public static string ColorAdded="Arabanın rengi eklendi";
        internal static string CustomerUpdated;
        internal static string CustomerIdList;
        internal static string CustomerListed;
        internal static string CustomerDeleted;
        internal static string CustomerAdded;
        internal static string RentalUpdated;
        internal static string RentalByCustomerId;
        internal static string RentalByCarId;
        internal static string RentalListed;
        internal static string RentalDeleted;
        internal static string RentalAdded;
        internal static string UserAdded;
        internal static string UserDeleted;
        internal static string UserListed;
        internal static string UserByIdListed;
        internal static string UserDetails;
        internal static string UserUpdated;
        internal static string RentalInvalid;
    }
}
