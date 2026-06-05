List<Student> students = new List<Student>();

bool running = true;

while (running)
{
    Console.WriteLine("\n===== Student Grade Tracker =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Exit");

    Console.Write("Choose option: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Console.Write("Enter student name: ");

            string name = Console.ReadLine();

            Student student = new Student(
                students.Count + 1,name);

            students.Add(student);

            Console.WriteLine("Student added successfully.");

            break;

        case 2:

            running = false;

            break;

        default:

            Console.WriteLine("Invalid choice.");

            break;
    }
}