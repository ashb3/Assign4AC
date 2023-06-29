using Assignment4Template;
using Assignment4Template.Data;

namespace CSharpAssignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentListCreator list = new StudentListCreator();
            List<Student> students = list.GetStudents();
            var StudentsEnrolled = students.Where(s => s.CurrentlyEnrolled).OrderBy(s => s.Lastname)
                .ThenBy(s => s.Firstname)
                .ThenBy(s => s.Id)
                .GroupBy(s => s.Course);
            var Courses = StudentsEnrolled.OrderBy(h => h.Key.CourseSection);
            foreach (var course in Courses)
            {
                Console.WriteLine($"Course Name: {course.Key.CourseName}, Course Description: {course.Key.CourseDescription}, Course Section: {course.Key.CourseSection}");
                foreach (var student in course)
                {
                    Console.WriteLine($"Last Name: {student.Lastname}, First Name: {student.Firstname}, Age: {student.Age}, ID: {student.Id}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}