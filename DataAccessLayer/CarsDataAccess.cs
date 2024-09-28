using Dapper;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CarsDataAccess
    {
        public void AddCar(Car car)
        {
            //first step we need our connection string
            string connectionString = ConfigurationManager.ConnectionStrings["GarageSoftwareConnectionString"].ConnectionString;

            string query = @"insert into Cars( Registration, Make, Model, Front_Brake_Remaining, Rear_Brake_Remaining, Anti_Freeze_Strength, Odometer)
                             values( @Registration, @Make, @Model, @Front_Brake_Remaining, @Rear_Brake_Remaining, @Anti_Freeze_Strength,@Odometer)";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, car);
            }
        }
    }
}
