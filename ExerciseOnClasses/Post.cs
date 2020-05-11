using System;

namespace CSharpIntermediate
{
    class Post
    {
        string decision = "";
        public string title { get; set; }
        public string description { get; set; }
        public readonly DateTime postDate = DateTime.Now;
        private Int32 _votes;

        public void UpVote()
        {
            this._votes += 1;
        }

        public void DownVote()
        {
            this._votes -= 1;
        }

        public void displayVotes()
        {
            Console.WriteLine("votes : {0}", _votes);
        }

        public void PostExecute()
        {
            Console.WriteLine("Enter the title");
            this.title = Console.ReadLine();
            Console.WriteLine("Enter the post description");
            this.description = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter upvote or downvote to rate the post");
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Description: {0}", this.description);
            while (decision != "exit")
            {
                decision = Console.ReadLine();
                if (decision == "upvote")
                    this.UpVote();
                else if (decision == "downvote")
                    this.DownVote();
                else if (decision == "exit")
                    Console.WriteLine("ok");
                else
                    Console.WriteLine("not a valid input");
            }
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Description: {0}", this.description);
            this.displayVotes();
        }
    }
}
