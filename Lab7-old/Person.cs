namespace Lab7;

public abstract class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public string DisplayInfo()
    {
        var info = $"Player Name: {Name}, his Age: {Age}";
        return info;
    }

}
