using HalmolenCA.Domain.Common;


namespace HalmolenCA.Domain.Entities.Facilities;

public class Floor
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public int Level { get; private set; }

    private Floor() { }

    public static Result<Floor> Create(string name, int level)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result<Floor>.Failure("De Naam mag niet leeg zijn.");
        }
        if (level < -10)
        {
            return Result<Floor>.Failure("Je kan maximaal 10 verdiepingen onder de grond gaan.");
        }

        if(level > 10)
        {
            return Result<Floor>.Failure("Je kan maximaal 10 verdiepingen boven de grond gaan.");
        }

        var n = name.Trim();

        var floor = new Floor
        {
            Name = n,
            Level = level
        };
        return Result<Floor>.Success(floor);
    }
}
