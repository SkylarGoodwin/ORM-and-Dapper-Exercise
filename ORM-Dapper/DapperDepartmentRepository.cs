using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _conn;

        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<department> GetAllDepartments()
        {
            return _conn.Query<department>("select * from departments");
        }
        public void InsertDepartment(string name)
        {
            _conn.Execute("insert into departments (Name) values (@name)", new {name = name});
        }
    }
}
