using Entities.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Module
    {
        public string Module_name { get; set; }
        public double Progress { get; set; }
        public StatusModule Status { get; set; }
        public List<Class> Classes { get; set; }
    }
}
