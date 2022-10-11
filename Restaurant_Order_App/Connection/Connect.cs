using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_App.Connection
{
    public class Connect
    {
        private SqlConnection instance = null;

        public Connect()
        {

        }

        public void getConnect()
        {
            string connectionString = $"Server={ConnectionUtils.Server}; Database={ConnectionUtils.Database}; Integrated Security=True;";
            this.instance = new SqlConnection(connectionString);
            this.instance.Open();
        }


    }
}
