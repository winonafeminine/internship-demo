using internship_api.Models.locations.thLocation.model;
using internship_api.Models.locations.thLocation.param;

namespace internship_api.Models.locations.thLocation
{
    public partial class ThLocationImp : IThLocation
    {

        public IEnumerable<ThLocationModel> GetRangeFromParam(GetParam param)
        {
            IEnumerable<ThLocation> locations = dbContext!.IntThLocations
                .OrderBy(t => t.Province)
                .Where(t => t.Province!.Contains(param.Name))
                .Take(param.Limit);

            IList<ThLocationModel> models = new List<ThLocationModel>();

            if(locations.Any())
            {
                foreach (ThLocation location in locations)
                {
                    ThLocationModel model = new ThLocationModel();
                    model.SetLocation(location);
                    models.Add(model);
                }
                return models;
            }

            return models;
        }

    }
}