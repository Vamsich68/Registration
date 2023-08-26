using Registration.Models;
using System.Data;
using System.Data.SqlClient;

namespace Registration.Repo
{
    public class RegistrationRepo : IRegistartion
    {
        private IDbConnection db;

        public RegistrationRepo(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public RegistrationDetails Add(RegistrationDetails registration)
        {
            var sql = "INSERT INTO Registration(Name, EmailId, MobileNumber, Password) VALUES (@Name, @EmailId,@MobileNumber, @Password)";
            return db.Query<>(sql,new { registration.Name, registration.EmailId,registration.MobileNumber,registration.Password});

        }
    }
}
