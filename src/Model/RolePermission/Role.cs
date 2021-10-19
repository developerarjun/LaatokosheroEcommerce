using System.ComponentModel.DataAnnotations;

namespace LaatokosheroBackEnd.src.Model.RolePermission
{
    public class Role
    {
        public int id {get;set;}
        [Required]
        public string RoleName {get;set;}
    }
}