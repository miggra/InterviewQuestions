using System;
using System.Linq;
using InterviewEntityFramework;
using InterviewEntityFramework.Entities;

class Program
{
    static void Main(string[] args)
    {
        // Projection question
        // foreach (var blog in context.Blogs)
        // {
        //     Console.WriteLine("Blog: " + blog.Url);
        // }

        // foreach (var blogName in context.Blogs.Select(b => b.Url))
        // {
        //     Console.WriteLine("Blog: " + blogName);
        // }

        // SplitQueryQuestion
        // var blogs = context.Blogs
        // .Include(b => b.Posts)
        // .ToList();
        //
        // var blogs = context.Blogs
        //     .Include(blog => blog.Posts)
        //     .AsSplitQuery()
        //     .ToList();

        // Explosion question
        // var blogs = context.Blogs
        // .Include(b => b.Posts)
        // .Include(b => b.Contributors)
        // .ToList();
    }
}