using System.Collections.Generic;
using FastFootApp.Roles.Dto;

namespace FastFootApp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
