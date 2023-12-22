var teacher = new Teacher();
teacher.Name = Console.ReadLine();
teacher.Age = Convert.ToInt32(Console.ReadLine());
teacher.Nationality = Console.ReadLine();

System.Console.WriteLine(teacher.GetName());

System.Console.WriteLine(teacher.GetAge());

System.Console.WriteLine(teacher.GetNationality());

System.Console.WriteLine(teacher.Introduce());

System.Console.WriteLine(teacher.CelebrateBirthday());

class Teacher
{
    public string Name;
    public int Age;
    public string Nationality; 

    public Teacher() {}
    public Teacher(string name,int age) {}
    public Teacher(string name,int age, string nationality) {}

    public string GetName()
    {
        return $"{Name}";
    }
    public string GetAge()
    {
        return $"{Age}";
    }
    public string GetNationality()
    {
        return $"{Nationality }";
    }
    public string Introduce()
    {
        return $"My name is {Name}.I am {Age} years old.I am from {Nationality}.";
    }
    public string CelebrateBirthday()
    {
        return $"{Age + 1}";
    }
}