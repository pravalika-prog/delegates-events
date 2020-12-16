using System;
using System.Collections.Generic;
using System.Text;

namespace Events2
{
  public  class Eligible_to_apply
    {
        public event EventHandler<personEventArgs> apply_person;
       public void eligibility()
        {
            Console.WriteLine("enter the age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the experience ");
            int experience = int.Parse(Console.ReadLine());
        if(age>30 && experience > 2)
            {
                Console.WriteLine("eligible to aply");
                apply_person(this, new personEventArgs(age,experience));
           
            }
            else
            {
                Console.WriteLine("not eligible to applly");
            }
        }
    }
}
