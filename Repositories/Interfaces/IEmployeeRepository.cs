using ApiSample.Entities;

namespace ApiSample.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(int empNo);

        Task<List<Employee>> GetEmployees(string deptNo);
    }
}
