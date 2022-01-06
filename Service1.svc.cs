using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServerDatabse
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Employee> getAllEmployees()
        {
            var EmployeeList = new List<Employee>();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91879\source\repos\WcfServerDatabse\App_Data\Database1.mdf;Integrated Security=True");

            SqlCommand com = new SqlCommand("Select * from Employee;", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Employee obj = new Employee();
                    obj.EmpId = reader.GetInt32(0);
                    obj.Name = reader.GetString(1);
                    obj.Salary = reader.GetDouble(2);
                    EmployeeList.Add(obj);
                }
            }
            else
            {
                //No Reader
            }
            reader.Close();
            return EmployeeList;
        }

    }
}
