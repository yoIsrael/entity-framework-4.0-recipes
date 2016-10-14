﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cleanup();
            RunExample();
        }

        static void Cleanup()
        {
            using (var context = new EFRecipesEntities())
            {
                context.ExecuteStoreCommand("delete from chapter13.resume");
            }
        }

        static void RunExample()
        {
            using (var context = new EFRecipesEntities())
            {
                var r1 = new Resume { Title = "C# Developer", Name = "Sally Jones" };
                r1.ResumeDetail = new ResumeDetail { Body = "...very long resume goes here..." };
                context.Resumes.AddObject(r1);
                context.SaveChanges();
            }

            using (var context = new EFRecipesEntities())
            {
                var resume = context.Resumes.Single();
                Console.WriteLine("Title: {0}, Name: {1}", resume.Title, resume.Name);
               
                // note, the ResumeDetail is not loaded until we reference it
                Console.WriteLine("Body: {0}", resume.ResumeDetail.Body);
            }

            Console.WriteLine("Press <enter> to continue...");
            Console.ReadLine();
        }
    }
}
