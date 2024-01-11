public class SchoolRepository
{
    private SchoolDataStorage dataStorage;

    public SchoolRepository()
    {
        dataStorage = SchoolDataStorage.Instance;
    }

    public void AddStudent(Student student)
    {
        dataStorage.Students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        dataStorage.Teachers.Add(teacher);
    }

    public void AddSubject(Subject subject)
    {
        dataStorage.Subjects.Add(subject);
    }
}
