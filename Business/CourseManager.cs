using KodlamaioIntro.Entities;

namespace KodlamaioIntro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
    {
        Course course = new Course();
        course.Id = 1;
        course.Name = "C#";
        course.Description = "C# Dersleri";
        course.Price = 0;

        Course course1 = new Course();
        course1.Id = 2;
        course1.Name = "Python";
        course1.Description = "Python Dersleri";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 3;
        course2.Name = "Java";
        course2.Description = "Java Dersleri";
        course2.Price = 0;

        courses[0] = course;
        courses[1] = course1;
        courses[2] = course2;
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
