using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCodeCampTutorial
{
    class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes Salad");
        }

        public void MakeFish()
        {
            Console.WriteLine("The chef makes Fish");
        }

        public virtual void MakeSpecial() //virtual means the method can be overwritten by a sub class
        {
            Console.WriteLine("The chef makes BBQ ribs");
        }


    }
}
