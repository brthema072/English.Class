using Entities.Entities;
using Entities.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Lesson
    {
        public string Utterance { get; set; }
        public string Description { get; set; }
        public TypeLesson Type { get; set; }
    }
}
