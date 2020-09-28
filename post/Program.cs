using System;

namespace post
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post("Alex Curnow", "First Post", "This is my first post!");

            newPost.upVote(5);
            newPost.upVote(50);
            newPost.downVote(12);

            newPost.display();
        }
    }
}
