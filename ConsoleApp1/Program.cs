class student
{
    private string name;
    private int id;
    private int age;
    private static int studentCount = 0;

    public string Name
    {  get { return name; }
        set {  name = value; }
    }
    
    public static int StudentCount
    { get { return StudentCount; } 
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {name}, ID: {id}, Age: {age}");
    }




}
