using System.Collections.Generic;
using Armut.Roles.Dto;

namespace Armut.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}