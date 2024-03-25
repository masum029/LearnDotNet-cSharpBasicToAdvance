using UI.Models;

namespace UI.Linq
{
    public class LinqQuerySyntax
    {
        public LinqQuerySyntax()
        {

            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            var result= from s in stringList
                        where s.Length > 0 && s.StartsWith("C#") && s.EndsWith("s")
                        select s;

        }


        #region Collection      

        public IEnumerable<Student> stdList()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            // LINQ Query Syntax to find out teenager students
            IEnumerable<Student>  teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            return teenAgerStudent;
        }

        public IQueryable<Student> iQuaryablestdList()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            // LINQ Query Syntax to find out teenager students
            IQueryable<Student> teenAgerStudent = from s in studentList.AsQueryable()
                                                   where s.Age > 12 && s.Age < 20
                                                   select s;
            return teenAgerStudent;
        }
        #endregion


    }
}
