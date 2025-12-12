using System;
using System.Collections.Generic;

public class User
{
    public string Name;
    public int Age;
    public List<User> Friends = new();
    public List<Post> Posts = new();

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void AddFriend(User user)
    {
        if (user == this)
        {
            Console.WriteLine("❌ You cannot add yourself as a friend.");
            return;
        }

        if (Friends.Contains(user))
        {
            Console.WriteLine("❌ You already added this friend.");
            return;
        }

        Friends.Add(user);
        Console.WriteLine($"{Name} added {user.Name} as a friend.");
    }

    public void RemoveFriend(User user)
    {
        if (Friends.Remove(user))
        {
            Console.WriteLine($"{Name} removed {user.Name} from friends.");
        }
        else
        {
            Console.WriteLine("❌ Friend not found.");
        }
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n📢 {Name}'s News Feed:");

        foreach (var friend in Friends)
        {
            foreach (var post in friend.Posts)
            {
                Console.WriteLine($"➡️ {friend.Name} posted: \"{post.Content}\" (Likes: {post.Likes.Count})");

                foreach (var c in post.Comments)
                {
                    Console.WriteLine($"     - {c.Author.Name} commented: \"{c.Content}\" (Likes: {c.Likes.Count})");
                }
            }
        }

        Console.WriteLine();
    }
}

