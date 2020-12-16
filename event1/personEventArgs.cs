using System;
using System.Collections.Generic;
using System.Text;

namespace Events2
{
    public class personEventArgs : EventArgs
    {
        public personEventArgs(int a, int b)
        {
            age = a;
            experience = b;

        }


        public int age { get; set; }
        public int experience { get; set; }
    }
}
