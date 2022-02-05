namespace internship_api.Models.locations.thLocation.model
{
    public class ThLocationModel : ThLocation
    {
        public void SetLocation(ThLocation location)
        {
            this.Province=location.Province;
            this.District=location.District;
            this.Subdistrict=location.Subdistrict;
            this.ZipCode=location.ZipCode;
            this.Latitude=location.Latitude;
            this.Longitude=location.Longitude;
            this.Id=location.Id;
        }
    }
}