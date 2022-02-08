using Microsoft.AspNetCore.Mvc;

namespace internship_api.Models.locations.thLocation.param
{
    [BindProperties]
    public class Param
    {
        public virtual int Limit { get; set; }
        public virtual string Name { get; set; } = null!;
    }
}