using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Class
    {
        public string Title { get; set; }
        public short Level { get; set; }
        public double Progress { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
