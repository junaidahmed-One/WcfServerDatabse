using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServerDatabse
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    { 
        [OperationContract]
        List<Employee> getAllEmployees();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {
        string name;
        int empid;
        double salary;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public int EmpId
        {
            get { return empid; }
            set { empid = value; }
        }

        [DataMember]
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}



