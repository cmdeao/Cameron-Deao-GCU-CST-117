//Corrected by Cameron Deao
//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.AddElement(r.Next(4));
                B.AddElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.Union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}

    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool AddElement(int val)
        //public bool addElement(int val)
        //Naming rule violation. Should being with upper case characters.
        {
        if (ContainsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }


        private bool ContainsElement(int val)
        //private bool containsElement(int val)
        //Naming rule violation. Should being with upper case characters.
        {
        for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //This code is unreachable in the execution of the program.
                //else
                //    return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void ClearSet()
        //public void clearSet()
        //Naming rule violation. Should being with upper case characters.
        {
        elements.Clear();
        }

        public Set Union(Set rhs)
        //public Set union(Set rhs)
        //Naming rule violation. Should being with upper case characters.
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.AddElement(rhs.elements[i]);
            }
            return rhs;
        }
    }