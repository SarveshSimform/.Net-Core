using Practical_17.Web.Contracts;
using Practical_17.Web.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Web.Repositories
{
    public class StudentRepositories : GenericRepositories<Student>, IStudentRepositories
    {
        public StudentRepositories(ApplicationDbContext context):base(context)
        {

        }
    }
}
