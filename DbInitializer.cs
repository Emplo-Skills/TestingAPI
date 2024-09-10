using TestingAPI.Models;

namespace TestingAPI
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any projects.
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var projects = new Project[]
            {
                new Project{Title="Project 1", Description="This is project 1", Status="Completed", PictureURL="https://picsum.photos/200/300"},
                new Project{Title="Project 2", Description="This is project 2", Status="Completed", PictureURL="https://picsum.photos/200/300"},
                new Project{Title="Project 3", Description="This is project 3", Status="Completed", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 4", Description="This is project 4", Status="Active", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 5", Description="This is project 5", Status="Active", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 6", Description="This is project 6", Status="Active", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 7", Description="This is project 7", Status="Active", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 8", Description="This is project 8", Status="Active", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 9", Description="This is project 9", Status="Active", PictureURL = "https://picsum.photos/200/300"},
                new Project{Title="Project 10", Description="This is project 10", Status="Active", PictureURL = "https://picsum.photos/200/300"}
            };
            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

        }

    }
}
