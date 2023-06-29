using Assignment4Template.Data;

namespace Assignment4Template
{
    public class StudentListCreator
    {
        public StudentListCreator()
        {
            courses = new List<Course>();
            students = new List<Student>();
            int seed = DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            random = new Random(seed);
            GenerateCourses();
        }

        private Random random { get; set; }
        private List<Course> courses { get; set; }
        private List<Student> students { get; set; }

        private void GenerateCourses()
        {
            courses.Add(new Course()
            {
                CourseName= "Angular",
                CourseDescription = "Into to Angular",
                CourseSection = 1
            });

            courses.Add(new Course()
            {
                CourseName = "Devops",
                CourseDescription = "Into to Devops",
                CourseSection = 2
            });

            courses.Add(new Course()
            {
                CourseName = "C#",
                CourseDescription = "Into to C#",
                CourseSection = 3
            });

            courses.Add(new Course()
            {
                CourseName = "Html",
                CourseDescription = "Into to Web Design",
                CourseSection = 4
            });

            courses.Add(new Course()
            {
                CourseName = "Design Principles",
                CourseDescription = "Into to Design Principles",
                CourseSection = 5
            });
        }

        public List<Student> GetStudents()
        {
            var studentCount = random.Next(50, 300);

            for(int i = 0; i < studentCount; i++)
            {
                var student = new Student();
                student.Id = i + 1;
                student.Age = random.Next(20, 51);
                student.CurrentlyEnrolled = random.Next(11) % 2 == 0;
                student.Firstname = Constants.FirstName[random.Next(Constants.FirstName.Count)];
                student.Lastname = Constants.LastName[random.Next(Constants.LastName.Count)];

                if(student.CurrentlyEnrolled)
                {
                    student.Course = courses[random.Next(courses.Count)];
                    student.Course.Students.Add(student);
                }

                students.Add(student);
            }

            return students;
        }
    }
}
