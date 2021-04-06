using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // General Messages
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string Welcome = "Hoş Geldiniz";
        public static string GoodTrip = "İyi Yolculuklar Dileriz";
        public static string CarImageLimitExceeded = "Resim Limitine Ulaşıldı";
        public static string CarImageListed = "Araba resimleri listelendi";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        //Auth Messages
        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        // Car Messages
        public static string CarAdded = "Araba Eklendi";
        public static string NoCarAdded = "Araba Eklenemedi";
        public static string CarsListed="Arabalar Listelendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarNameInValid = "Araba İsmi Geçersiz";
        public static string CarAddError = "Eklemek istediğiniz araba zaten mevcut.Farklı bir araba giriniz.";

        // Rental Messages
        public static string RentalAdded = "Kiralama Başarılı";
        public static string NoRentalAdded = "Kiralama Başarılı Değil";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string RentalInValid = "Kiralama Geçersiz";
        public static string RentedCarAlreadyExists = "Araba Zaten Kiralanmış";

        //User Messages
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string NoUserAdded = "Kullanıcı Eklenemedi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserAddError = "Eklemek istediğiniz kullanıcı zaten mevcut.Farklı bir kullanıcı giriniz.";

        //Customer Messages
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string NoCustomerAdded = "Müşteri Eklenemedi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerNameInValid = "Müşteri İsmi Geçersiz";
        public static string CustomerAddError = "Eklemek istediğiniz müşteri zaten mevcut.Farklı bir müşteri giriniz.";

        //Brand Messages
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";

        //Color Messages
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";

        //Credit Card Messaes
        public static string CreditCardAdded = "Kredi Kartı Eklendi";
        public static string CreditCardDeleted = "Kredi Kartı Silindi";
        public static string CreditCardUpdated = "Kredi Kartı Güncellendi";
        
    }
}
