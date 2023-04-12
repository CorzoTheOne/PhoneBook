﻿using PhoneBook.Data;
using PhoneBook.Data.Entities;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var dbContext = new BlogDbContext();

        var postObject = new Post { Title = "My First Post" };
        postObject.Comments.Add(new Comment { Body = "This is my first comment" });

        dbContext.Posts.Add(postObject);
        _ = await dbContext.SaveChangesAsync();

        Console.WriteLine("test success?");
    }
}