using System.Collections.Generic;
using FastFootApp.Roles.Dto;

namespace FastFootApp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}