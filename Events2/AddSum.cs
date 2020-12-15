using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
  public  class AddSum
    {
        public event EventHandler<OddNumberEventArgs> od_number;
        public void fun()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            if (result % 2 != 0)&& (od_number != null){
                od_number(this, new OddNumberEventArgs(result));
            }
        }
    }
}
