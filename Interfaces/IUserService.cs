
using Microsoft.VisualBasic;
using Project.Models;

namespace Project.interfaces
{
    public interface IUserService
    {
        List<User> GetAllList();

        User GetUserById(int id);

        void Create(User newUser);

        void Update(int id, User user);
        void Delete(int id,string type,int userId);
        User? GetExistUser(User user);
        string? Login (User? existUser);
         public User? GetExistUserAfterSignInWithGoogle(User user);

        


    }
}    