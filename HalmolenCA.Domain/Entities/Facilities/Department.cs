using HalmolenCA.Domain.Common;

namespace HalmolenCA.Domain.Entities.Facilities;

public class Department
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public bool IsActive { get; private set; } = true;

    public bool IsCareDepartment { get; private set; } = true;

    private Department() { }

    public static Result<Department> Create(string name, bool isCareDepartment)
    {
        if (string.IsNullOrWhiteSpace(name.ToString()))
        {
            return Result<Department>.Failure("Naam mag niet leeg zijn.");
        }
        var n = name.Trim();
       
        var department = new Department
        {
            Name = n,
            IsCareDepartment = isCareDepartment
        };
        return Result<Department>.Success(department);
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate() {
        IsActive = false;
    }
}
