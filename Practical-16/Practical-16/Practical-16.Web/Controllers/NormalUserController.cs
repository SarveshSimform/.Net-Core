using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practical_16.Web.Contracts;
using Practical_16.Web.Contstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Web.Controllers
{
    [Authorize(Roles = Roles.User)]
    public class NormalUserController : Controller
    {
        private readonly IStudentRepositories studentRepositories;

        public NormalUserController(IStudentRepositories studentRepositories)
        {
            this.studentRepositories = studentRepositories;
        }

        public async Task<IActionResult> Index()
        {
            return View(await studentRepositories.GetAllAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await studentRepositories.GetAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
