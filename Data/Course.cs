
namespace Assignment4Template.Data
{
    public class Course
    {
        public Course()
        {
            Students = new List<Student>();
        }

        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseSection { get; set; }

        public List<Student> Students { get; set; }
    }
}
