namespace Lab7;

public abstract class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public abstract string DisplayInfo();

}
