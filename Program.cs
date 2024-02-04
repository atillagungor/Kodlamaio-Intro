using KodlamaioIntro.Business;
using KodlamaioIntro.Entities;

namespace KodlamaioIntro;

internal class Program
{
    static void Main(string[] args)
    {
        CourseManager courseManager = new();
        Course[] courses2 = courseManager.GetAll();

        for (int i = 0; i < courses2.Length; i++)
        {
            Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
        }
    }
}
