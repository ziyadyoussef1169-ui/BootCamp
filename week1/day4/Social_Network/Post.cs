using System;
using System.Collections.Generic;

public class Post
{
    public User Author;
    public string Content;
    public List<Comment> Comments = new();
    public List<User> Likes = new();

    public Post(User author, string content)
    {
        Author = author;
        Content = content;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
        Console.WriteLine($"{comment.Author.Name} commented on {Author.Name}'s post.");
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine("❌ You already liked this post.");
            return;
        }

        Likes.Add(user);
        Console.WriteLine($"{user.Name} liked {Author.Name}'s post.");
    }
}
