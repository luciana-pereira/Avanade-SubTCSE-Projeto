using System.Threading.Tasks;
using Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Interfaces.Services;
using System;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
