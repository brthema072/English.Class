using Entities.Entities;
using Entities.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class User : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Score { get; set; }
        public short Level { get; set; }
        public CategoryUser Category { get; set; }
        public List<Module> Modules { get; set; }
        public bool Active { get; set; }
    }
}
