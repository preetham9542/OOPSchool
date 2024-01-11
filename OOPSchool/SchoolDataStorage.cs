using System.Collections.Generic;

public class SchoolDataStorage
{
    private static SchoolDataStorage instance;
    public List<Student> Students { get; private set; }
    public List<Teacher> Teachers { get; private set; }
    public List<Subject> Subjects { get; private set; }

    private SchoolDataStorage()
    {
        Students = new List<Student>();
        Teachers = new List<Teacher>();
        Subjects = new List<Subject>();
    }

    public static SchoolDataStorage Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SchoolDataStorage();
            }
            return instance;
        }
    }
}
