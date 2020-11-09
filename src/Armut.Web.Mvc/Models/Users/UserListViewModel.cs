using System.Collections.Generic;
using Armut.Roles.Dto;

namespace Armut.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
