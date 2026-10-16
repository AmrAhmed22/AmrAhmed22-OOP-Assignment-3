namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var students = new Store<Student>();

            students.Add(new Student(1, "Amr"));
            students.Add(new Student(2, "Ahmed"));
            students.Add(new Student(3, "Khaled"));
            students.Add(new Student(4, "Omar"));
            students.Add(new Student(5, "Aly"));

            var courses = new Store<Course>();
            courses.Add(new Course(101, "C#", 1500));
            courses.Add(new Course(102, "SQL", 1200));
            courses.Add(new Course(103, "ASP.NET", 2000));

            Console.WriteLine($"Student 3: {students.GetById(3)?.Name}");
            Console.WriteLine($"Course 102: {courses.GetById(102)?.Title}");

            try
            {
                students.Add(new Student(1, "Duplicate Amr"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }

            Console.WriteLine("\nPage 2 of students (size 2):");
            foreach (var s in students.GetAll().Page(2, 2))  // here is a benefit of using IEnumrable in GetAll() also! 
            {
                Console.WriteLine($"- {s.ID}: {s.Name}");
            }


           // var invalidStore = new Store<string>();
        
        
        }
    }
}
