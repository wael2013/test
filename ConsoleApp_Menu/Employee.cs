using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Menu
{
    class Employee : IComparable
    {
        public static char c = 'n';
        public string Name;
        public int ID;
        public float Salary;
        public Employee(int id, string name, float salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return string.Format("ID:{0} \t Name:{1} \t Salary:{2}", ID, Name, Salary);
        }


        public int CompareTo(object obj)
        {
            // return string.Compare(Name, (obj as Employee).Name, true);

            int v = 0;
            switch (c)
            {
                case 'n':

                    v = (string.Compare(Name, (obj as Employee).Name, true));
                    break;

                case 'i':
                    if (ID == (obj as Employee).ID)
                        v = 0;
                    else
                    {
                        if (ID > (obj as Employee).ID)
                            v = 1;
                        else
                            v = -1;
                    }
                    break;
                case 's':
                    if (Salary == (obj as Employee).Salary)
                        v = 0;
                    else
                    {
                        if (Salary > (obj as Employee).Salary)
                            v = 1;
                        else
                            v = -1;
                    }
                    break;
            }
            return v;
        }
    }

    class Employee2 : IComparable
    {
        public static char c = 'n';
        public string Name;
        public int ID;
        public float Salary;
        public delegate int comp(object o);
        public comp co;
        public Employee2(int id, string name, float salary)
        {
            ID = id;
            Name = name;
            Salary = salary;

        }
        public override string ToString()
        {
            return string.Format("ID:{0} \t Name:{1} \t Salary:{2}", ID, Name, Salary);
        }

        public int CompareTo(object obj)
        {
            return c;
        }
        public int comparebyID(object o)
        {
            int v = 0;
            if (ID == (o as Employee).ID)
                v = 0;
            else
            {
                if (ID > (o as Employee).ID)
                    v = 1;
                else
                    v = -1;
            }
            return v;
        }
        public int comparebySalary(object o)
        {
            int v = 0;
            if (Salary == (o as Employee).Salary)
                v = 0;
            else
            {
                if (Salary > (o as Employee).Salary)
                    v = 1;
                else
                    v = -1;
            }
            return v;
        }
        public int comparebyName(object o)
        {
            int v = 0;
            v = (string.Compare(Name, (o as Employee).Name, true));
            return v;
        }
    }
}
