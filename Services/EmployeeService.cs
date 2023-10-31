using ApiSample.Entities;
using ApiSample.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(
            IEmployeeRepository employeeRepository
            )
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<Employee> GetEmployee(int empNo)
        {
            return await _employeeRepository.GetEmployee(empNo);
        }

        public async Task<List<Employee>> GetEmployees(string deptNo)
        {
            return await _employeeRepository.GetEmployees(deptNo);
        }
    }
}
