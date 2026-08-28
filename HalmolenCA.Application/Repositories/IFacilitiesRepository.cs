using HalmolenCA.Domain.Common;

namespace HalmolenCA.Application.Repositories;

public interface IFacilitiesRepository
{
    Task<Result<bool>> FloorExistAsync(string name, int level, CancellationToken ct);
    Task<Result<bool>> DepartmentExistAsync(string name);

    Task<Result<bool>> RoomExistOnDepartment(int departmentId, string roomName);

}
