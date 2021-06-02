using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserRegistered = "Kullanıcı oluşturuldu";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string StudentsListed="Öğrenciler listelendi";
        public static string StudentAdded="Öğrenci Eklendi";
    }
}
