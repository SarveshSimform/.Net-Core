using Practical_16.Web.Contracts;
using Practical_16.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Web.Repositories
{
    public class StudentRepositories : GenericRepositories<Student>, IStudentRepositories
    {
        public StudentRepositories(ApplicationDbContext Context) : base(Context)
        {
        }
    }
}
