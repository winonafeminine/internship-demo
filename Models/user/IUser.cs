using internship_api.Models.user.model;
using internship_api.Models.user.route;

namespace internship_api.Models.user
{
    public interface IUser
    {
        Task<Res> AddAsync(AddModel model);

        // get all users
        // using UserModel
        IEnumerable<UserModel> GetRange();

        // get the user by name async
        Task<UserModel> GetAsync(GetRoute route);

    }
}