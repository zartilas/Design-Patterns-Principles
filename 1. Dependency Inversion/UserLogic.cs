namespace _1._Dependency_Inversion
{
    public class UserLogic
    {
        private IUserDataAccess _UserDataAccess;

        public UserLogic()
        {
            _UserDataAccess = DataAccessFactory.GetUserDataAccessObj();
        }

        public User GetUserDetails(int id)
        {
            return _UserDataAccess.GetUserDetails(id);
        }
    }
}