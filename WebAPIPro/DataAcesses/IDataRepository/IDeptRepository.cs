using WebAPIPro.Models;

namespace WebAPIPro.DataAcesses.DataRepository
{
    public interface IDeptRepository
    {
        Task<int> InsertDepartment(Department Dept);
        Task<List<Department>> AllDepartments();

        Task<List<Department>> GetDepartmentsByLocation(string Location);
        Task<Department> GetDepartmentByDeptNo(int DeptNo);

        Task<int> UpdateDepartment(Department Dept);

        Task<int> DeleteDepartment(int DeptNo);


    }
}
