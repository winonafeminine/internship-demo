using Microsoft.EntityFrameworkCore;

namespace internship_api.Models.user
{
    public partial class UserImp : IUser
    {
        public async Task<User> FindByNameAsync(string? name)
        {
            User? user = await dbContext!.IntUsers!.SingleOrDefaultAsync(u => u.Name == name);

            return user!;
        }
    }
}