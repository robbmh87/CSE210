using System;
using System.Collections.Generic;

namespace VideoComments
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video v1 = new Video("Introduction to Adulting, is it worth it? ", "Robb Hoffman", 300);
            v1.Comments.Add(new Comment("Mom", "Great video!"));
            v1.Comments.Add(new Comment("Dad", "Thanks for the tutorial!"));
            v1.Comments.Add(new Comment("Sister", "Very helpful, thanks!"));
            videos.Add(v1);

            Video v2 = new Video("Can we survive without eating?", "Joe Smo", 450);
            v2.Comments.Add(new Comment("Bob", "Nice explanation of eating, I'm going to pass!"));
            v2.Comments.Add(new Comment("Jenna", "I dont get it."));
            v2.Comments.Add(new Comment("Carli", "I literally cant even begin to understand this"));
            videos.Add(v2);

            Video v3 = new Video("Why do bills exist?", "Bill Collector", 200);
            v3.Comments.Add(new Comment("Peter", "I avoid these videos!"));
            v3.Comments.Add(new Comment("John", "I pay my bills with monopoly money lol"));
            v3.Comments.Add(new Comment("Mark", "Life is so unfair"));
            videos.Add(v3);

            foreach (Video v in videos)
            {
                Console.WriteLine("Title: " + v.Title);
                Console.WriteLine("Author: " + v.Author);
                Console.WriteLine("Length: " + v.Length + " seconds");
                Console.WriteLine("Number of comments: " + v.GetNumComments());
                Console.WriteLine("Comments:");

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("- " + c.Name + ": " + c.Text);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
