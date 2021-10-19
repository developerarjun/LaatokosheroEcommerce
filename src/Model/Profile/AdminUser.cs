using System.ComponentModel.DataAnnotations;

namespace LaatokosheroBackEnd.src.Model.Profile
{
    public class AdminUser
    {
        public int Id {get;set;}
        [Required]
        public int UserName {get;set;}
        [Required]
        public string UserPassword {get;set;}
        [Required]
        public string FirstName {get;set;}
        public string MiddleName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        public string PhoneNumber {get;set;}
        [Required]
        public string Address {get;set;}
    }
}