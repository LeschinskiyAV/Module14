using System.Runtime.InteropServices;

List<Student> students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};
var coarses = new List<Coarse>
{
   new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
   new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
};
var result = from s in students
             let YearOfBirth = DateTime.Now.Year - s.Age
             where s.Age < 29
             where s.Languages.Contains("английский")
             from coarse in coarses
             where coarse.Name.Contains("C#")
             select new
             {
                 s.Name,
                 YearOfBirth,
                 CoarseName = coarse.Name
             };
foreach (var student in result)
    Console.WriteLine(student.Name + ", " + student.YearOfBirth + ", " + student.CoarseName);
class Coarse
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }

}