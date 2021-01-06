using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
public Video Video { get; set; }
    }
 public   class Videoencoder
    {
        public event EventHandler<VideoEventArgs> VideOuploaded;
        public void Encode(Video video)
        {
            Console.WriteLine("video is uploaded");
            Onvideouploaded(video);
        }
       // public event EventHandler<> VideOuploaded;
        protected virtual void Onvideouploaded(Video video)
        {
            if (VideOuploaded != null)
                VideOuploaded(this, new VideoEventArgs() { Video = video });
        }
    }
}
