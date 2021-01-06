using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
 public   class Messageservice
    {
        public void Onvideouploaded(object source,VideoEventArgs e)
        {
            Console.WriteLine("message service :"+  e.Video.Title);
            
        }
    }
}
