using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public abstract class Door
    {
        public abstract string Type { get; }
        public abstract int Id { get; set; }
        public abstract Prize Prize { get; set; }
    }
}
