using HalmolenCA.Application.Repositories;
using HalmolenCA.Domain.Common;
using HalmolenCA.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace HalmolenCA.Infrastructure.Persistence.Repositories;

public class FacilitiesRepository(HalmolenDbContext context) : IFacilitiesRepository
{
    public Task<Result<bool>> DepartmentExistAsync(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<bool>> FloorExistAsync(string name, int level, CancellationToken ct)
    {
        var levelExists = await context.Floors.AnyAsync(
            f => f.Level == level, ct);
        if (levelExists) return Result<bool>.Failure($"A floor with level {level} already exists.");
        
        var FloorNameExists = await context.Floors.AnyAsync(
            f => f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase), ct);
        if (FloorNameExists) return Result<bool>.Failure($"A floor with name {name} already exists.");
        return Result<bool>.Success(true);
    }

    public Task<Result<bool>> RoomExistOnDepartment(int departmentId, string roomName)
    {
        throw new NotImplementedException();
    }
}
