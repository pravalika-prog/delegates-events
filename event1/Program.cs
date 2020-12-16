using System;

namespace Events2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            



            Eligible_to_apply a = new Eligible_to_apply();
            a.apply_person += showmessage;
            a.eligibility();
        }
        static void showmessage(object sender, personEventArgs e)
        {
            Console.WriteLine("if your age is below 30 and experience is less than  2 :{0},{1}");
            }
        }
    }

