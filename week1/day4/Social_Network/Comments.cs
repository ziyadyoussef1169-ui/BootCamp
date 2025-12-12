using System;
using System.Collections.Generic;

public class Comment
{
    public User Author;
    public string Content;
    public List<User> Likes = new();

    public Comment(User author, string content)
    {
        Author = author;
        Content = content;
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine("❌ You already liked this comment.");
            return;
        }

        Likes.Add(user);
        Console.WriteLine($"{user.Name} liked {Author.Name}'s comment.");
    }
}
