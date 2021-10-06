using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Base
    {
        public Guid Id { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
