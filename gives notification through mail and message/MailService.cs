﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
  public  class MailService
    {
        public void Onvideouploaded(object source,VideoEventArgs e)
        {
            Console.WriteLine("mail sevice   :" +  e.Video.Title );
        }
    }
}
