using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2
{
    class Person
    {
            private string name;
            private int birthyear;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public int Birthyear
            {
                get
                {
                    return birthyear;
                }
                set
                {
                    birthyear = value;
                }
            }


            public Person(string name, int birthyear)
            {
                this.name = name;
                this.birthyear = birthyear;
            }

            public override string ToString()
            {
                return String.Format("{0}, born {1}", Name, Birthyear);
            }
    }
}
