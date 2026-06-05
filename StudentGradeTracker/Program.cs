StudentService service = new();

bool running = true;

while (running)
{
    Console.WriteLine("\n===== Student Grade Tracker =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Grade");
    Console.WriteLine("3. Show Students");
    Console.WriteLine("4. Top Student");
    Console.WriteLine("5. Exit");

    Console.Write("\nChoose option: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Console.Write("Student name: ");

            string name = Console.ReadLine();

            service.AddStudent(name);

            Console.WriteLine("Student added.");

            break;

        case 2:

            Console.Write("Student Id: ");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade: ");

            double grade = Convert.ToDouble(Console.ReadLine());

            service.AddGrade(id, grade);

            break;

        case 3:

            service.ShowStudents();

            break;

        case 4:

            service.ShowTopStudent();

            break;

        case 5:

            running = false;

            break;

        default:

            Console.WriteLine("Invalid option.");

            break;
    }
}