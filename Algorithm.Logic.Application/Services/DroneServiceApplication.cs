using Algorithm.Logic.CrossCutting;
using Algorithm.Logic.Domain.Factory;
using Algorithm.Logic.Domain.Specification;

namespace Algorithm.Logic.Application.Services
{
    /// <summary>
    /// Service intermediatary layer responsible of  coordinates response
    /// </summary>
    public class DroneServiceApplication
    {
        public string GetCoordinate(string entry)
        {
            var drone = new DroneFactory(entry).Build();

            Container.Instance._contents.Add(drone);
            Container.Instance._contents.Add(drone.Coordinate);

            return Container.Instance.IsSafetyPacked() ? drone.GetCoordinate()
                                                       : Constant.ErrorValueDefault;
        }
    }
}
