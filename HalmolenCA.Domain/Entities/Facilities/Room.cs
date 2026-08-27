using HalmolenCA.Domain.Common;
using HalmolenCA.Domain.Services;

namespace HalmolenCA.Domain.Entities.Facilities
{
    public class Room
    {
        public int Id { get; private set; }
        public int FloorId { get; private set; }
        public int DepartmentId { get; private set; }
        public string RoomName { get; private set; }
        public bool IsActive { get; private set; } = true;
        public bool PatientRoom { get; private set; } = false;

        private Room() { }

        public static async Task<Result<Room>> Create(string roomName, int floorId, int departmentId, bool patientRoom, IFacilitiesService service)
        {
            if (string.IsNullOrWhiteSpace(roomName))
            {
                return Result<Room>.Failure("De Naam mag niet leeg zijn.");
            }
            var r = roomName.Trim();
            var roomDoesNotExistResult = await service.RoomDoesNotExistOnDepartment(departmentId, r);
            if(!roomDoesNotExistResult.IsSuccess)
            {
                return Result<Room>.Failure(roomDoesNotExistResult.Message);
            }
            var room = new Room
            {
                RoomName = r,
                FloorId = floorId,
                DepartmentId = departmentId,
                PatientRoom = patientRoom
            };
            return Result<Room>.Success(room);
        }


    }
}
