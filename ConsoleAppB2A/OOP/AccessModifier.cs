using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppB2A.OOP
{
    public class AccessModifier
    {
        public AccessModifier()
        {

            //There are 5 different access modifiers in c#.
            //1.Private
            //2.Protected
            //3.Internal
            //4.Protected Internal
            //5.Public        
            Console.WriteLine("From Access modifier Constructor");
        }

        public void returnAccessLevel(int acclevel)
        {
            Console.WriteLine("From Private Method");
        }

        private void returnAccessLevel()
        {
            Console.WriteLine("From Private Method");
        }
        protected void returnAccessLevel(string name)
        {
            Console.WriteLine("From Private Method "+name);
        }

        internal void returnAccessLevel(string name, string accMod="Internal")
        {
            Console.WriteLine("From Private Method " + name +" & AccessMod is "+accMod);
        }
       protected internal void returnAccessLevel(string name, string accMod = "Internal", string DoubleAM="Protected")
        {
            Console.WriteLine("From Private Method " + name + " & AccessMod is " + DoubleAM+" "+ accMod);
        }
    }

   class AccessModifierPrivate
    {
        public AccessModifierPrivate()
        {
            AccessModifier accessModifier = new AccessModifier();
            accessModifier.returnAccessLevel(1);
            
        }

    }


}
