using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class HashTable
    {
        private List<Person> people=new List<Person>(366);

        public void Add(Person p)
        {
            HashFunction();
        }
        public void HashFunction() { }
    }
}
