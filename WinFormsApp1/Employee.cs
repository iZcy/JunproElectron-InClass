using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Employee
    {
        public int EmployeeID = 0;
        public string LoginName = "";
        public string Password = "";

        public Employee()
        { }

        public Employee(int employeeID, string employeeUsername, string employeePassword)
        {
            EmployeeID = employeeID;
            LoginName = employeeUsername;
            Password = employeePassword;
        }

        public Boolean Login(string LoginName, string Password)
        {
            if (LoginName == "Jono" && Password == "wkwk")
            {
                EmployeeID = 1;  
                return true;
            }
            else if (LoginName == "Jones" && Password == "haha")
            {
                EmployeeID = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
