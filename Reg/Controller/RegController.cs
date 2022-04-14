using Dapper;
using Reg.Model;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Reg.Controller
{
    internal class RegController
    {
        public RegController()
        {

        }

        public void Registration(string _email, string _pass)
        {
            string connectionString = @"Data Source=krababster;Initial Catalog=TestDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                UserData regestration = new UserData() { user_email = _email, user_password = new Scrypt().Generate(_pass) };
                connection.Execute("INSERT INTO UserData (user_email, user_password) VALUES(@user_email,@user_password)", regestration);
            }
        }

        public List<UserData> Validate()
        {
            string connectionString = @"Data Source=krababster;Initial Catalog=TestDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                return connection.Query<UserData>("SELECT user_email FROM UserData").ToList();
            }
        }
    }
}
