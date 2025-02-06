using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Soyadı")]
        public string Surname { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string? Phone { get; set; }
        [Display(Name ="Şifre")]
        public string Password { get; set; }
        [Display(Name="Kullanıcı Adı")]
        public string? UserName { get; set; }
        [Display(Name="Aktif?")]
        public bool IsActive { get; set; }
        [Display(Name="Admin?")]
        public bool IsAdmin { get; set; }
        [Display(Name="Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }
        [ScaffoldColumn(false)]
        public Guid? UserGuid { get; set; }

        //Kullanıcıya özgü, benzersiz bir kimlik oluşturmak için kullanılır.
        //Guid(Global Unique Identifier), dünya çapında benzersiz bir değer üretir.


    }
}
