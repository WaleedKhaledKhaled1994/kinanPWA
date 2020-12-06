using PWA.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories.Interfaces
{
    public interface IUser
    {
        Task AssignRole(EditRoleDTO editRole);
        Task<List<RoleDTO>> GetRoles();
        Task RemoveRole(EditRoleDTO editRole);
    }
}
