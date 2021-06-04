using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Models;
using Microsoft.EntityFrameworkCore;
using SchoolTest.Db;


namespace SchoolTest.Service
{
    public class SchoolService : BaseService
    {
        public SchoolService(SchoolContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Student>> GetStudents() { 
            return await Context.Students.
                Where(x => x.Active).ToListAsync();
        }
    }
}
