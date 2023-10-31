using ApiSample.Entities;
using ApiSample.Repositories.Interfaces;

namespace ApiSample.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository() 
        {
            _employees = new List<Employee>()
            {
                new Employee
                {
                    EmpNo = 1,
                    EmpName = "A",
                    DeptNo = "B1",
                    DeptName = "BName",
                    CreateDate = DateTime.Now
                },
                new Employee
                {
                    EmpNo = 2,
                    EmpName = "B",
                    DeptNo = "B2",
                    DeptName = "B2Name",
                    CreateDate = DateTime.Now
                },
                new Employee
                {
                    EmpNo = 3,
                    EmpName = "C",
                    DeptNo = "B1",
                    DeptName = "BName",
                    CreateDate = DateTime.Now
                },
            };
        }


        public async Task<Employee> GetEmployee(int empNo)
        {
            return await Task.FromResult(_employees.SingleOrDefault(o => o.EmpNo == empNo));
        }

        public async Task<List<Employee>> GetEmployees(string deptNo)
        {
            

            return await Task.FromResult(_employees.FindAll(o => o.DeptNo == deptNo));
        }
    }
}
