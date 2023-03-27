using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstration with YouTube Videos!");
        Console.WriteLine("");

        List<Comment> catComments = new List<Comment>();
        Comment catcomment1 = new Comment("Purrtastic", "The cats are so Cute!<3");
        Comment catcomment2 = new Comment("Fur for Me", "I adore white cats the most.");
        Comment catcomment3 = new Comment("Meow is right", "This cat look like my Cotton just less cute. My cat is the superior fluff.");
        catComments.Add(catcomment1);
        catComments.Add(catcomment2);
        catComments.Add(catcomment3);
        Video video1 = new Video("Cat Video", "Cat Man", 120, catComments);
        video1.DisplayVideo();

        List<Comment> dogComments = new List<Comment>();
        Comment dogcomment1 = new Comment("Ruffkins", "The way he talks back at the end of the video is my favorite.");
        Comment dogcomment2 = new Comment("Bow to Wow", "What an precious friend. I can't get enough!");
        Comment dogcomment3 = new Comment("To tuff for Ruff", "What a weak looking dog. My german sheapard would eat it for Kibble.");
        Comment dogcomment4 = new Comment("Spots on spot", "My Spots approves of this video and demands for more.");
        dogComments.Add(dogcomment1);
        dogComments.Add(dogcomment2);
        dogComments.Add(dogcomment3);
        dogComments.Add(dogcomment4);
        Video video2 = new Video("Dog Video", "Dog World", 180, dogComments);
        video2.DisplayVideo();

        List<Comment> bunnyComments = new List<Comment>();
        Comment bunnycomment1 = new Comment("MY NAME IS FLUFFY", "The cats are so Cute!<3");
        Comment bunnycomment2 = new Comment("Bunnsy", "The bunny's chocolate brown fur is so smooth. That is a well loved bunny.");
        Comment bunnycomment3 = new Comment("Cuddle the Cotton", "This cat look like my Cotton just less cute. My cat is the superior fluff.");
        bunnyComments.Add(bunnycomment1);
        bunnyComments.Add(bunnycomment2);
        bunnyComments.Add(bunnycomment3);
        Video video3 = new Video("Bunny Video", "Mr. Hop", 60, bunnyComments);
        video3.DisplayVideo();
    }
}