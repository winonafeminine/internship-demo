using internship_api.Models.user.model;
using internship_api.Models.user.route;

namespace internship_api.Models.user
{
    public partial class UserImp : IUser
    {
        public async Task<UserModel> GetAsync(GetRoute route)
        {
            
            User user = await FindByNameAsync(route.Name);


            UserModel model = new UserModel();

            if(user == null)
            {
                return model;
            }
            
            model.SetUser(user);

            return model;
        }
    }
}