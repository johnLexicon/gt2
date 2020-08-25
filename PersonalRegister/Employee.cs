using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    class Employee
    {
        
        private string name;
        private int monzz;


        public Employee(string name, int money)
        {
            this.name = name;
            this.monzz = money;
        }

        public Employee getName()
        {
            return this;
        }

        

    }
}
