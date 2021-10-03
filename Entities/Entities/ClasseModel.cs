using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class LessonsModel : BaseModel
    {
        public short Level { get; set; }
        public List<MatterModel> Matters { get; set; }
    }
}
