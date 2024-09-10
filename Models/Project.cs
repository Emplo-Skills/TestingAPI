using Swashbuckle.AspNetCore.Annotations;

namespace TestingAPI.Models
{
    //This class is used to represent a project in the database

    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string PictureURL { get; set; }

    }

    public class ProjectDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string PictureURL { get; set; }
    }
}
