using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
 public   class EnterName
    {
        public event EventHandler<BannedUserEventArgs> ev_BannedUser;
        public void User()
        {
            Console.Write("Enter You Name : ");
            string user = Console.ReadLine();

            if ((user == "Jack" || user == "Steven" || user == "Mathew") && (ev_BannedUser != null))
            {
                ev_BannedUser(this, new BannedUserEventArgs(user));
            }
            else
            {
                Console.WriteLine("Welcome to " + user);
            }
        }
    }
}
