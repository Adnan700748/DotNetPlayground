public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<double> Grades { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
        Grades = new List<double>();
    }
}