using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace np.Models
{
    public class User
    {
        public int UserId { get; set; }
        [JsonRequired]
        public string Email { get; set; }
        [JsonIgnore]
        public IList<UserCourse> UserCourses { get; set; }
    }
}
