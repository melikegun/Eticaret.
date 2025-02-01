namespace Eticaret.Core.Entities
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public string? UserName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? UserGuid { get; set; }

        //Kullanıcıya özgü, benzersiz bir kimlik oluşturmak için kullanılır.
        //Guid(Global Unique Identifier), dünya çapında benzersiz bir değer üretir.


    }
}
