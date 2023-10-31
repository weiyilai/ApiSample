using ApiSample.Entities;

namespace ApiSample.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployee(int empNo);

        Task<List<Employee>> GetEmployees(string deptNo);
    }
}
