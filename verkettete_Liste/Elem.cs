using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verkettete_Liste
{
    internal class Elem
    {
        public Elem next { set; get; } = null;
        public Elem previous { set; get; } = null;
        public int number { set; get; }

    }
}
