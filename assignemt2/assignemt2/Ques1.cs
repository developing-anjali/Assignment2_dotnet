/*class Student
{
    string Name;
    int RollNo;
    int[] Marks = new int[5];
    int TotalMarks;
    float Percentage;

    static string UniversityName;

    public Student()
    {
        Name = "";
        RollNo = 0;
        TotalMarks = 0;
        Percentage = 0;
        for (int i = 0; i < 5; i++)
        {
            Marks[i] = 0;
        }
    }

    public Student(string name, int rollNo, int[] marks)
    {
        Name = name;
        RollNo = rollNo;
        TotalMarks = 0;
        Percentage = 0;
        Marks = marks;
    }

    static Student()
    {
        UniversityName = "GLA University";
    }

    public void ReadData()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Roll No: ");
        RollNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Subject " + i + 1 + ":");
            Marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void CalculateResult()
    {
        TotalMarks = 0;
        for (int i = 0; i < 5; i++)
        {
            TotalMarks += Marks[i];
        }
        Percentage = TotalMarks / 5;
    }

    public void Display()
    {
        Console.WriteLine("University: " + UniversityName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll No: " + RollNo);
        Console.Write("Marks: ");
        foreach (var mark in Marks)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Total Marks: " + TotalMarks);
        Console.WriteLine("Percentage: " + Percentage + "%");
    }

    public static void SetName(string universityName)
    {
        UniversityName = universityName;
    }

    public static string GetName()
    {
        return UniversityName;
    }
}

class Ques1
{
    static void Main()
    {
        Student.SetName("GLA University");

        Student student1 = new Student();
        student1.ReadData();
        student1.CalculateResult();
        student1.Display();

        int[] marks = { 85, 90, 78, 92, 88 };
        Student student2 = new Student("Sanskriti", 45, marks);
        student2.CalculateResult();
        student2.Display();
    }
}
*/