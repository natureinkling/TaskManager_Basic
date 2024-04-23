using Microsoft.EntityFrameworkCore;
using TaskManager.Context;

namespace TaskManager.Data
{
    public class UserService
    {
        private readonly ApplicationDBContext _applicationdbContext;
        public UserService(ApplicationDBContext applicationDBContext)
        {
            _applicationdbContext = applicationDBContext;
        }

        //Add new user
        public async Task<bool> AddNewUser(User u)
        {
            await _applicationdbContext.Users.AddAsync(u);
            await _applicationdbContext.SaveChangesAsync();
            return true;
        }

        //Check if the user record exists
        public async Task<bool> CheckIfExists(User u)
        {
            bool userExists = await _applicationdbContext.Users.AnyAsync(user =>
                user.UserID == u.UserID &&
                user.UserName == u.UserName &&
                user.Password == u.Password &&
                user.Email == u.Email);

            //If user exists
            if (userExists)
            {
                return true;
            }

            return false;
        }
    }
}
