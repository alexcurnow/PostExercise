using System;

namespace post
{
    public class Post
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        private int _upVoteCount { get; set; }
        private int _downVoteCount { get; set; }

        public Post(string author, string title, string content)
        {
            Author = author;
            Title = title;
            Content = content;
            
        }
        
        public int upVote(int upVotes)
        {
            return _upVoteCount += upVotes;
        }

        public int downVote(int downVotes)
        {
            return _downVoteCount += downVotes;
        }

        public void display()
        {
            Console.WriteLine($"{this.Title} by {this.Author}: {this.Content}");
            Console.WriteLine($"UpVotes: {this._upVoteCount} // DownVotes: {this._downVoteCount}");
        }
    }
}
