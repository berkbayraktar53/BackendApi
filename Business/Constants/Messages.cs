using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public readonly static string ProductAdded = "Ürün başarıyla eklendi";
        public readonly static string ProductDeleted = "Ürün başarıyla silindi";
        public readonly static string ProductUpdated = "Ürün başarıyla güncellendi";

        public readonly static string CategoryAdded = "Kategori başarıyla eklendi";
        public readonly static string CategoryDeleted = "Kategori başarıyla silindi";
        public readonly static string CategoryUpdated = "Kategori başarıyla güncellendi";

        public readonly static string UserAdded = "Kullanıcı başarıyla eklendi";
        public readonly static string UserDeleted = "Kullanıcı başarıyla silindi";
        public readonly static string UserUpdated = "Kullanıcı başarıyla güncellendi";

        public readonly static string UserNotFound = "Kullanıcı bulunamadı";
        public readonly static string PasswordError = "Şifre hatalı";
        public readonly static string SuccessfulLogin = "Sisteme giriş başarılı";
        public readonly static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public readonly static string UserRegistered = "Kulanıcı başarıyla kaydedildi";
        public readonly static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public readonly static string AuthorizationDenied = "Yetkiniz yok";
    }
}