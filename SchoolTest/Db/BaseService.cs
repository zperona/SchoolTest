using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Db;

namespace SchoolTest.Service
{
    public class BaseService
    {
        protected readonly SchoolContext Context;

        public BaseService(SchoolContext context)
        {
            Context = context;
        }
    }
}
