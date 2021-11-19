using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Şifre Hatali";
        public static string SuccessfulLogin = "Sisteme Giris Basarili";
        public static string UserAlreadyExists = "Kullanici Zaten Mevcut";
        public static string UserRegistered = "Kullanici Basariyla Kaydedildi";
        public static string AccessTokenCreated = "Access Token Basariyla Olusturuldu";
    }
}
