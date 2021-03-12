namespace _1._Dependency_Inversion
{
    public class UserDataAccess : IUserDataAccess
    {
        public User GetUserDetails(int id)
        {
            User user = new User()
            {
                ID = id,
                Name = "Some name",
                Username = "Some username",
                Password = "1234"
            };
            return user;
        }
    }
}