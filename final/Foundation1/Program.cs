using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("The Starting Line", "The Duke of Cheese",31536000));
        videos.Add(new Video("The Fall of Arcadea", "Abidon The Distroyer", 7200));
        videos.Add(new Video("Pigs And Mud", "Pyglet", 2024));
        videos.Add(new Video("Rel-axe", "The Axe Man", 3221));

        videos[0].AddComment(new Comment("ThatOneGuy", "Comment"));
        videos[0].AddComment(new Comment("TheCheeseNapper", "That Pepper Jack!"));
        videos[0].AddComment(new Comment("TheDuke'sDog", "You better pay that Chesse Tax!!!"));
        videos[0].AddComment(new Comment("BillyBoBJOE", "SoOo hAS that Wehel gOTTedn of dA LIne"));

        videos[1].AddComment(new Comment("Angron", "For Korn!!"));
        videos[1].AddComment(new Comment("ThatOneGuy", "Comment"));
        videos[1].AddComment(new Comment("BasmentGuard", "So that's why it thought we had an PlanetQuake..."));

        videos[2].AddComment(new Comment("Bacon", "**Oink**"));
        videos[2].AddComment(new Comment("ThatAngryPrimark", "You shouldn't say that!"));
        videos[2].AddComment(new Comment("ThatOneGuy", "Comment"));

        videos[3].AddComment(new Comment("ThatOneGuy", "Comment"));

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("");
        }
    }
}