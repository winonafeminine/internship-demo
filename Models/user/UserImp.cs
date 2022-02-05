namespace internship_api.Models.user
{
    public partial class UserImp : IUser
    {
        private readonly IntDbContext? dbContext;
        public UserImp(IntDbContext? dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}