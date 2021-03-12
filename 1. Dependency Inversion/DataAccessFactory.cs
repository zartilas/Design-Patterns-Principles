namespace _1._Dependency_Inversion
{
    public class DataAccessFactory
    {
        public static IUserDataAccess GetUserDataAccessObj()
        {
            return new UserDataAccess();
        }
    }
}