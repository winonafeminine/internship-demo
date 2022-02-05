using internship_api.Models.user.model;

namespace internship_api.Models.user
{
    public partial class UserImp : IUser
    {
        public IEnumerable<UserModel> GetRange()
        {
            IEnumerable<User> users = dbContext!.IntUsers!
                .OrderBy(o => o.ModifiedDate);

            IList<UserModel> models = new List<UserModel>();

            foreach(User user in users)
            {
                UserModel model = new UserModel();
                model.SetUser(user);
                models.Add(model);
            }

            return models;
        }
    }
}