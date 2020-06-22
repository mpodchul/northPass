using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace np.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [JsonRequired]
        public string Name { get; set; }
        [JsonIgnore]
        public IList<UserCourse> UserCourses { get; set; }
    }

    public class CourseWithCount : Course
    {
        public CourseWithCount(Course course)
        {
            CourseId = course.CourseId;
            Name = course.Name;
        }
        public int StudentsCount { get; set; }
    }
}
