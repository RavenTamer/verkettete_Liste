using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verkettete_Liste
{
    internal class Zahlenspeicher
    {
        Elem firstelem = null;
        int counter = 0;
        public void Add(int number) 
        {
            counter++;
            Elem newelem = new Elem();
            newelem.number = number;
            if(firstelem == null)
            {
                firstelem = newelem;
            }
            else
            {
                
                Elem elem = firstelem;
                while (elem.next != null)
                {
                    elem = elem.next;
                }
                elem.next = newelem;
            }
        }
        private void Clear() { }
        private bool Contains(int number) {
            return true;
        }
        public string[] Get() 
        {
            string[] zahlenspeicher = new string[counter];
            Elem elem = firstelem;
            int i = 0;
            while (elem.next != null)
            {
                zahlenspeicher[i] = elem.number.ToString();
                elem = elem.next;
                i++;
            }
            zahlenspeicher[i] = elem.number.ToString();
            return zahlenspeicher;
        }
    }
}
