using Microsoft.Data.SqlClient;
using ST.Model;

namespace ST.DataAccess
{
    public class SqlServerAccess
    {

        private string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        
        public int createStudent(Student student) { 
             SqlConnection objSqlConnection=new SqlConnection(ConnectionString);
            objSqlConnection.Open();

            string query = $"INSERT INTO StudentTable (FirstName,LastName,Email,Age) VALUES('{student.FirstName}','{student.LastName}','{student.Email}','{student.Age}')";

            SqlCommand sqlCommand = new SqlCommand(query,objSqlConnection);
            sqlCommand.CommandText = query;
            sqlCommand.Connection = objSqlConnection;
            sqlCommand.CommandType=System.Data.CommandType.Text;    

            int result=sqlCommand.ExecuteNonQuery();

            if(objSqlConnection.State==System.Data.ConnectionState.Open)
            {
                objSqlConnection.Close();
            }
            return result;

        }
    
    }
}