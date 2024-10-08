using WebAPIPro.Models;

namespace WebAPIPro.DataAcesses.DataRepository
{
    public interface IEmpRepository
    {
        Task<int> InsertEmployee(Employee Emp);

        Task<int> UpdateEmployee(Employee Emp);

        Task<int> DeleteEmployee(int EmpNo);

        Task<Employee> GetEmployeeById(int empId);

        Task<Employee> GetEmployeeByName(string empName);

        Task<List<Employee>> GetAllEmployees();

        Task<Employee> GetEmployeeByEmailAndPassword(string email, string password);

        Task<List<Employee>> GetEmployeeByGender(string gender);

    }
}
