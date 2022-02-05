namespace internship_api.Models.locations.thLocation
{
    public partial class ThLocationImp : IThLocation
    {
        private readonly IntDbContext? dbContext;
        public ThLocationImp(IntDbContext? dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}