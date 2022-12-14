using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verkettete_Liste
{
    internal class SortOrder
    {
        Zahlenspeicher zs = new();
        public void Ascending()
        {
            int smallest = 0;
            string[] zahlenspeicher = zs.Get();
            for(int i = 0; i<zahlenspeicher.Length; i++)
            {
                if(Convert.ToInt32(zahlenspeicher[i]) < smallest)
                {
                    smallest = Convert.ToInt32(zahlenspeicher[i]);
                }

            }
        }
        public void Descending()
        {

        }
    }
}

