namespace NikAmozBooklet.Razor.Models
{
    public class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
