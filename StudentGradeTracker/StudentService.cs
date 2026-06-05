public class StudentService
{
    private List<Student> students = new();

    public void AddStudent(string name)
    {
        Student student = new Student(
            students.Count + 1,
            name);

        students.Add(student);
    }

    public void AddGrade(int studentId, double grade)
    {
        Student student = students.FirstOrDefault(
            s => s.Id == studentId);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        student.Grades.Add(grade);
    }

    public void ShowStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"\nId: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");

            if (student.Grades.Count == 0)
            {
                Console.WriteLine("Grades: None");
            }
            else
            {
                Console.WriteLine(
                    $"Grades: {string.Join(", ", student.Grades)}");
            }

            Console.WriteLine(
                $"Average: {student.GetAverage():F2}");
        }
    }

    public void ShowTopStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        Student topStudent = students
            .OrderByDescending(s => s.GetAverage())
            .First();

        Console.WriteLine("\n===== Top Student =====");
        Console.WriteLine($"Name: {topStudent.Name}");
        Console.WriteLine(
            $"Average: {topStudent.GetAverage():F2}");
    }
}