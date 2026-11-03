using ClassSchoolTask.Models;

namespace ClassSchoolTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student cavidan = new Student("Cavidan", "Rüstəmli", "Back-End", 80);

            cavidan.GetInfo();
            cavidan.CheckGraduation();
            cavidan.GetDiplomDegree();
        }
    }
}
