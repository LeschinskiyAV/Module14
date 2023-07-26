List<Student> students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};

var result = from s in students
             where s.Age < 27
             let birthYear = DateTime.Now.Year - s.Age
             select new Application()
             {
                 Name = s.Name,
                 YearOfBirth = birthYear
             };

foreach (var student in result)
    Console.WriteLine(student.Name + ", " + student.YearOfBirth);
         
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }

}
public class Application
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
}
