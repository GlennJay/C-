using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCodeCampTutorial
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The italian chef makes pasta");
        }

        public override void MakeSpecial()
        {
            Console.WriteLine("The italian chef makes chicken parm");
        }
    }
}
