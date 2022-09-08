using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyPractices
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        //Constructor
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Departments> GetAllDepartments()
        {
          var depos = _connection.Query<Departments>("select * from departments;").ToList();
            
          return depos;
            
        }
        public void InsertDeparments(string newDepartmentName)
        {
            _connection.Execute("insert into departments (name) Values (@departmentName);",
           new { _connection = newDepartmentName });
        }
        

    }
}
