using System.ComponentModel.DataAnnotations.Schema;
using LaatokosheroBackEnd.src.Model.RolePermission;

namespace LaatokosheroBackEnd.src.Model.Profile
{
    public class UserRole
    {
        public int UserId {get;set;}
        [ForeignKey("UserId")]
        public AdminUser AdminUsers {get;set;}
        public int RoleId {get;set;}
        [ForeignKey("RoleId")]
        public Role Roles {get;set;}
    }
}