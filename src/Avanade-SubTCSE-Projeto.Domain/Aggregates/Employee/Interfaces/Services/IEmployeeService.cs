using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
