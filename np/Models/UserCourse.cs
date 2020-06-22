using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace np.Models
{
    public class UserCourse
    {
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public int CourseId { get; set; }
        [JsonIgnore]
        public Course Course { get; set; }
    }
}
