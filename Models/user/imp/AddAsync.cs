using internship_api.Models.user.model;

namespace internship_api.Models.user
{
    public partial class UserImp : IUser
    {
        public async Task<Res> AddAsync(AddModel model)
        {
            Res res = new Res{
                Status=200,
                Message="OK"
            };

            User user = new User{
                Name=model.Name,
                LastName=model.LastName
            };

            // ! null-forgiving operator
            // used to inform the compiler that an actual null value isn't possible
            // docs: https://docs.microsoft.com/en-us/ef/core/miscellaneous/nullable-reference-types
            if(user != null)
            {
                await dbContext!.IntUsers!.AddAsync(user);
                await dbContext.SaveChangesAsync();

                return res;
            }

            res.Status = 204;
            res.Message = "No Content";
            return res;
        }
    }
}