using Microsoft.AspNetCore.Mvc;
using Login.Models;
using System.Data.SqlClient;
namespace Login.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
        void ConnectionString()
        {
            connection.ConnectionString = "Data Source=SUDHARSHAN;Initial Catalog=LOGINDB;Integrated Security=True";
        }
        public ActionResult Verify(Logins login)
        {
            ConnectionString();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Select * From Login Where Username ='"+login.Username+"' Password='"+login.Password+"'";
            dataReader = command.ExecuteReader();
            if(dataReader.Read())
            {
                connection.Close();
                return View();
            }
            else
            {
                connection.Close();
                return View();
            }
            
        }
    }
}
