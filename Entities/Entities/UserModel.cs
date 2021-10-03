using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Score { get; set; }
        public short Level { get; set; }
        public LessonsModel CurrentLessons { get; set; }
        public List<LessonsModel> LessonsDone { get; set; }
    }
}
