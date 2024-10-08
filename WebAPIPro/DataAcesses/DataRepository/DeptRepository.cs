using Microsoft.EntityFrameworkCore;
using WebAPIPro.DataAcesses.DataRepository;
using WebAPIPro.DB_Context;
using WebAPIPro.Models;

namespace WebAPIPro.DataAcesses.IDataRepository
{
    public class DeptRepository : IDeptRepository
    {
        public QIS2Context QIS2Contextdb;

        public DeptRepository(QIS2Context _qIS2Contextdb)
        {
            QIS2Contextdb =_qIS2Contextdb;
        }

        public async Task<List<Department>> AllDepartments()
        {
            //throw new NotImplementedException();
            return await QIS2Contextdb.Departments.ToListAsync();
        }

        public async Task<int> DeleteDepartment(int DeptNo)
        {
            var depres= await QIS2Contextdb.Departments.FindAsync(DeptNo);
            QIS2Contextdb.Departments.Remove(depres);
            return await QIS2Contextdb.SaveChangesAsync();
        }

        public async Task<List<Department>> GetDepartmentByDeptLocation(string DeptLocation)
        {
            //throw new NotImplementedException();
            return await QIS2Contextdb.Departments.Where(x=>x.Location==DeptLocation).ToListAsync();
        }

        public async Task<Department> GetDepartmentByDeptNo(int DeptNo)
        {
            //throw new NotImplementedException();
            return await QIS2Contextdb.Departments.FindAsync(DeptNo);
        }

        public async Task<List<Department>> GetDepartmentsByLocation(string Location)
        {
                  return await QIS2Contextdb.Departments.Where(x=>x.Location==Location).ToListAsync();
        }

        public async Task<int> InsertDepartment(Department Dept)
        {
            //throw new NotImplementedException();
              QIS2Contextdb.Departments.AddAsync(Dept);
           return await QIS2Contextdb.SaveChangesAsync();
        }

        public async Task<int> UpdateDepartment(Department Dept)
        {
            QIS2Contextdb.Departments.Update(Dept);

            return await QIS2Contextdb.SaveChangesAsync();

        }

       
    }
}
