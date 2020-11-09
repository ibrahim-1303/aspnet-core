using System.Collections.Generic;
using Armut.Roles.Dto;

namespace Armut.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
