using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace np.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        public IList<UserCourse> UserCourses { get; set; }
    }
}
