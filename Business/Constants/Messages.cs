using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Məhsul Əlavə Olundu.";
        public static string ProductNameInvalid = "Məhsul adı uyğun deyil";
        public static string MaintenanceTime = "Təmir zamanı";
        public static string ProductListed = "Məhsullar Listələndi.";
        public static string ProductListedByCategoryId = "Mehsul Kateqoriye gore Listelendi";
        public static string CategoryLimitExceeded = "Izace verilen (15) Kategoqi sayi tamamlanmishdir";
        public static string ProductNameAlreadyExists = "Bu adla mehsul bazada movcuddur";
        public static string CountOfCategoryError = "Bir kateqoride en choxu 10 mehsul ola biler";
        public static string AuthorizationDenied = "Yetkin yok";
        public static string UserRegistered = "İstifadəçi qeydiyyatdan keçdi";
        public static string UserNotFound = "İstifadəçi tapılmadı";
        public static string PasswordError = "Şifrə xətası";
        public static string SuccessfulLogin = "Uğurlu giriş";
        public static string UserAlreadyExists = "İstifadəçi mövcuddur";
        public static string AccessTokenCreated = "Token yaradıldı";
    }
}
