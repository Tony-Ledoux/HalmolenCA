using HalmolenCA.Domain.Common;
using HalmolenCA.Domain.Services;

namespace HalmolenCA.Domain.Entities.Facilities
{
    public class Floor
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public int Level { get; private set; }

        private Floor() { }

        public static async Task<Result<Floor>> Create(string name, int level, IFacilitiesService service)
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

            var floorDoesNotExist = await service.FloorDoesNotExistAsync(n, level);
            if(!floorDoesNotExist.IsSuccess)
            {
                return Result<Floor>.Failure(floorDoesNotExist.Message);
            }

            var floor = new Floor
            {
                Name = n,
                Level = level
            };
            return Result<Floor>.Success(floor);
        }
    }
}
