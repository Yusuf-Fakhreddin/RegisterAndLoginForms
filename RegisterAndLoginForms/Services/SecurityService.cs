using RegisterAndLoginForms.Models;

namespace RegisterAndLoginForms.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();
        public SecurityService()
        {
        }
        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
            // return true if found in the list
        }
    }
}
