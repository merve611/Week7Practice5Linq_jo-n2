using Week7Practice5Linq_joın2;

internal class Program
{
    public static void Main(string[] args)
    {

        List<Student> students = new List<Student>();
        students.Add(new Student { StudentId = 1, ClassId = 1, StudentName = "Ali" });
        students.Add(new Student { StudentId = 2, ClassId = 2, StudentName = "Ayşe" });
        students.Add(new Student { StudentId = 3, ClassId = 1, StudentName = "Mehmet" });
        students.Add(new Student { StudentId = 4, ClassId = 3, StudentName = "Fatma" });
        students.Add(new Student { StudentId = 5, ClassId = 2, StudentName = "Ahmet" });



        List<Class> classes = new List<Class>();
        classes.Add(new Class { ClassId = 1, ClassName = "Matematik" });
        classes.Add(new Class { ClassId = 2, ClassName = "Türkçe" });
        classes.Add(new Class { ClassId = 3, ClassName = "Kimya" });


        //group joını class listesine göre yapıldı
        var studentsWithClasses = classes.GroupJoin(students,
                                                    student => student.ClassId,
                                                    classs => classs.ClassId,
                                                    (classs, classesStudent) => new
                                                    {
                                                        ClassesName = classs.ClassName,
                                                        StudentName = classesStudent       //class isimlerine erişmek için
                                                    });




        foreach (var student in studentsWithClasses)
        {
            Console.WriteLine(student.ClassesName);
            foreach (var classs in student.StudentName)
            {
                Console.WriteLine(classs.StudentName);
            }
            Console.WriteLine("--------------------");

        }

    }
}