using HalmolenCA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HalmolenCA.Domain.Services
{
    public interface IFacilitiesService
    {
        Task<Result<bool>> FloorDoesNotExistAsync(string name, int level);
        Task<Result<bool>> DepartmentDoesNotExistsAsync(string name);

        Task<Result<bool>> RoomDoesNotExistOnDepartment(int departmentId, string roomName);
    }
}
