using System.Collections.Generic;
using FastFootApp.Roles.Dto;

namespace FastFootApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
