static void Main()
        {
            var video = new Video() { Title ="pravalika" };
            var videoencoder = new Videoencoder();
            var mailservice = new MailService();
            var messageservice = new Messageservice();
            videoencoder.VideOuploaded += mailservice.Onvideouploaded;
            videoencoder.VideOuploaded += messageservice.Onvideouploaded;
            videoencoder.Encode(video);
        }
    }
}
