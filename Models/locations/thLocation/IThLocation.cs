using internship_api.Models.locations.thLocation.param;
using internship_api.Models.locations.thLocation.model;

namespace internship_api.Models.locations.thLocation
{
    public interface IThLocation
    {
        IEnumerable<ThLocationModel> GetRangeFromParam(GetParam param);
    }
}