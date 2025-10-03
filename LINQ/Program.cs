namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //LINQ Query Syntax
            Console.WriteLine("Even Numbers using Query Syntax:");
            var evenNumbersQuery = from num in numbers
                                   where num % 2 == 0
                                   select num;

            foreach (int num in evenNumbersQuery)
            {   Console.WriteLine(num); }

            //LINQ Method Syntax
            Console.WriteLine("Even Numbers using Method Syntax:");
            var evenNumbersMethod = numbers.Where(num => num % 2 == 0);
            foreach (int num in evenNumbersMethod)
            {   Console.WriteLine(num); }


            Console.WriteLine("Even Student:");

           
            List<Student> students = new List<Student>
            {
                new Student("Alice", 23),
                new Student("Bob", 22),
                new Student("Charlie", 24),
                new Student("David", 21),
                new Student("Eve", 23)
            };

            var orderdStudents = students.OrderBy(s => s.Name).ThenBy(s => s.Age).ToList();
            var orderedStudentsDesc = students.OrderByDescending(s => s.Name).ThenByDescending(s => s.Age).ToList();
            var groupedStudents = students.GroupBy(s => s.Age).ToList();
           
            
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Age Group: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($" - {student.Name}, Age: {student.Age}");
                }
            }

        }
        public class Student
        {
            public string Name { get; set; } 
            public int Age { get; set; }
            public Student() { }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
    
}
