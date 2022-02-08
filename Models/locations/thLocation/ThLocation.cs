namespace internship_api.Models.locations.thLocation
{
    public partial class ThLocation
    {
        public virtual string? Province { get; set; }
        public virtual string? District { get; set; }
        public virtual string? Subdistrict { get; set; }
        public virtual string? ZipCode { get; set; }
        public virtual string? Latitude { get; set; }
        public virtual string? Longitude { get; set; }
        public virtual int Id { get; set; }
    }
}
