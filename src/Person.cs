using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        private int id;
        private int range;
        private string name;

        public Person(int id, int range, string name)
        {
            this.id = id;
            this.range = range;
            this.name = name;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public int Range
        {
            get
            {
                return range;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Info
        {
            get
            {
                return name + " " + range; 
            }
        }

        public override string ToString()
        {
            return name;
        }

    }
}
