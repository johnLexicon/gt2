using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    class Company
    {
        public List<Employee> list;


        public Company()
        {
            this.list = new List<Employee>();
        }

        public void add(String name, int sal)
        {
            this.list.Add(new Employee(name, sal));
        }

        public void print()
        {
            foreach(Employee e in list)
            {
                Console.WriteLine(e);
            }
        }
        

        }
    }

