using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyPractices
{
    public class Departments : IDepartmentRepository 
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public IEnumerable<Departments> GetAllDepartments()
        {
            throw new NotImplementedException();
        }
    }
}
