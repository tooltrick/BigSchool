using BigSchools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchools.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}