using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {

            if(employeeTypeId == 0)
                return null;
            switch (employeeTypeId)
            {
                case 1:
                    return new PermanentEmployeeManager();
                case 2:
                    return new ContractEmployeeManager();
                default:
                    return null;
            }
        }
    }
}
