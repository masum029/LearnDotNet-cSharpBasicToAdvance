using UI.Models;

namespace UI.Linq
{
    public class LINQMethodSyntax
    {
        public LINQMethodSyntax()
        {
            // string collection
            IList<string> stringList = new List<string>() {
                                                "C# Tutorials",
                                                "VB.NET Tutorials",
                                                "Learn C++",
                                                "MVC Tutorials" ,
                                                "Java"
                                            };

            var result = stringList.Where(s => s.Contains("ri"));
        }

        public List<Student> students()
        {
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };


            var stdList = studentList.Where(x => x.Age >= 13 && x.Age < 21)
                .ToList<Student>();

            return stdList;

        }
    }
}
