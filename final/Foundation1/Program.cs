using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video = new Video("Supercraft E1", "spikej555", 18);
        video.AddComment("AceOfHearts", "You should look in the mob tower next time!");
        video.AddComment("patchfightsquarantine2302", "yuh");
        video.AddComment("imvastrox", "do another livestream ill watch");
        video.AddComment("forestsheadel54", "First comment");
        videos.Add(video);

        video = new Video("Believer | Audio Illusions", "Audio Illusions", 3);
        video.AddComment("trasholeenterprise1831", "Raise your hand if this piano sings better than you");
        video.AddComment("arthurmorgan319", "The sad part is there are people asking if they’re the only ones hearing the lyrics");
        video.AddComment("lolxd-we1iq", "\"Am I the only one who hears the lyrics?\" *FACEPALM*");
        video.AddComment("AlphaX01", "this piano is a legend it can play the drums");
        video.AddComment("user-yo3po4vg8x", "Nadie:\nEn serio, nadie:\nYoutube: Mira esta ilusión auditiva de hace 2 años, está mamalona");
        videos.Add(video);

        video = new Video("Spike plays CS2 - E1", "spikej555", 47);
        video.AddComment("MAXSTER777", "Really got me with that SC2013 intro!");
        video.AddComment("AdruinoGeek", "Dang, 20fps! CO needs to up their game");
        video.AddComment("cammiedundies1523", "u sound so professional doing that lol");
        video.AddComment("forrestsheadel54", "First comment");
        videos.Add(video);

        video = new Video("The Um Episode - Supercraft E1", "hockeye11", 25);
        video.AddComment("spikej555", "Glad to have you on the team!");
        video.AddComment("AceOfHearts", "What're the chances he'll beat the end dragon by his third video?");
        video.AddComment("callumizamonkey", "/warp MineBucks and my house down the road from it plz ;D");
        video.AddComment("saturdayknight7364", "Aren't we in a new map?");
        video.AddComment("forrestsheadel54", "First comment");
        videos.Add(video);

        foreach (Video vid in videos)
        {
            vid.Display();
        }
    }
}