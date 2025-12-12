using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Mini Social Network (Beginner Version) ===\n");

        User alice = new User("Alice", 25);
        User bob = new User("Bob", 30);
        User carol = new User("Carol", 22);

        alice.AddFriend(bob);
        bob.AddFriend(carol);

        Post post1 = new Post(alice, "Hello world!");
        alice.Posts.Add(post1);

        Comment c1 = new Comment(bob, "Nice post!");
        post1.AddComment(c1);

        post1.AddLike(bob);
        c1.AddLike(carol);

        bob.ShowFeed();
    }
}
