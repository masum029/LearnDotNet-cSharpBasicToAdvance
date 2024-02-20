using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppB2A.Basic
{
    public class MethodsAndParameters
    {
        public MethodsAndParameters()
        {

        }

        public void MethodsParametersAndArguments(string name)//Parameters
        {
            Console.WriteLine(name);
        }

        public void MethodsParametersAndArguments(string name, int Age, string Country = "BD")//Parameters
        {
            int retAge = ReturnAge(Age);
            Console.WriteLine(name + " Age:" + retAge);
        }

        public int ReturnAge(int _age)
        {
            return _age;
        }

        public string NamedArguments(string child1, string child2, string child3)
        {
            return child3+ ": John "+ child1+": Liam,"+ child2+ " :Liam";
        }


    }
}
