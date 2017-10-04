using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        private int range;
        private string name;

        public Person(int m_id, string m_name)
        {
            range = m_id;
            name = m_name;
        }

        public int Id
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
        public override string ToString()
        {
            return name;
        }

    }
}
