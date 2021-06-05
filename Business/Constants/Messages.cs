using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //genel mesaj  kısmım 
    public static class Messages //newlemeye gerek yok
    {
      
        public static string PatientCountOfDietError = "Hastanın Sadece Bir Diet Listedi Olabilir";

        public static string PatientAdded = "Hasta Eklendi";

        public static string PatientDeleted = "Hasta Silindi";

        public static string PatientsListed = "Hastalar Başarı İle Listelendi";

        public static string PatientUpdated = "Hastalar Listelendi";

        public static string DietAdd = "Diet Eklendi";

        public static string DietDeleted = "Diet Silindi";

        public static string DietUpdated = "Diet Güncellendi";

        public static string DiseaseAdd = "Hastalık Eklendi";

        public static string DiseaseDeleted = "Hastalık Silindi";

        public static string DiseaseUpdated = "Hastalık Güncellendi";

        public static string UserRegistered = "Kayıt Başarılı";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Parola Hatası";

        public static string SuccessfulLogin = "Giriş Başarılı";

        public static string DoctorAdd = "Diyetisyen Eklendi";

        public static string DoctorDeleted = "Diyetisyen Silindi";

        public static string DoctorUpdated = "Diyetisyen Güncellendi";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserAlreadyExists = "Kullanıcı Mevcut";

        public static string AccessTokenCreated = "Giriş Başarılı ";

        public static string USerDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string UserAdded { get; internal set; }
    }
}
