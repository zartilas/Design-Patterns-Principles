using System.Data;
using System.Data.SqlClient;

namespace _4._Data_Mapper
{
    public class CustomerDataMapper
    {
        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

        public static Customer GetByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SELECT TOP 1 * FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    // If the query returned a row, create the Customer object and return it.
                    if (reader.HasRows)
                    {
                        reader.Read();

                        string name = (string)reader["Name"];
                        bool isVIP = (bool)reader["IsVIP"];

                        return new Customer(id, name, isVIP);
                    }
                }
            }

            return null;
        }

        public void Save(Customer customer)
        {
        }

        public void Delete(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", customer.ID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
