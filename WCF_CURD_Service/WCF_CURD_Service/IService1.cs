using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_CURD_Service.Model;

namespace WCF_CURD_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertEmployee(Employee_Master emp);

        [OperationContract]
        string UpdateEmployee(Employee_Master emp);

        [OperationContract]
        string DeleteEmployee(Employee_Master emp);

        [OperationContract]
        List<Employee_Master> GetEmployees();

        [OperationContract]
        Employee_Master GetEmployeeById(int employeeId);
        
    }

}
