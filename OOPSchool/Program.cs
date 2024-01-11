using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchool
{
    class Program
    {
        static void Main()
        {
      
            SchoolRepository repository = new SchoolRepository();

            repository.AddStudent(new Student { Name = "Preetham", ClassAndSection = "10A" });
            repository.AddStudent(new Student { Name = "Praneeth", ClassAndSection = "11B" });

            repository.AddTeacher(new Teacher { Name = "Mr. Gajala", ClassAndSection = "10A" });
            repository.AddTeacher(new Teacher { Name = "Mrs. Devi K V", ClassAndSection = "11B" });

            repository.AddSubject(new Subject { Name = "MS-SQL", SubjectCode = "SQL101", Teacher = new Teacher { Name = "Mr. Gajala", ClassAndSection = "10A" } });
            repository.AddSubject(new Subject { Name = ".Net", SubjectCode = "NET101", Teacher = new Teacher { Name = "Mrs. Devi K V", ClassAndSection = "11B" } });

            DisplayStudentsInClass("11B");
            DisplaySubjectsTaughtByTeacher("Mrs. Devi K V");

            Console.ReadLine(); 
        }

        static void DisplayStudentsInClass(string className)
        {
            var studentsInClass = SchoolDataStorage.Instance.Students.Where(s => s.ClassAndSection == className);
            Console.WriteLine($"Students in {className}:");
            foreach (var student in studentsInClass)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }

        static void DisplaySubjectsTaughtByTeacher(string teacherName)
        {
            var subjectsByTeacher = SchoolDataStorage.Instance.Subjects.Where(s => s.Teacher.Name.Equals(teacherName, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Subjects taught by {teacherName}:");
            foreach (var subject in subjectsByTeacher)
            {
                Console.WriteLine($"- {subject.Name}");
            }
        }
    }

}
