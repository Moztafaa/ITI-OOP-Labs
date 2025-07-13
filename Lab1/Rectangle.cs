namespace Lab1;

public class Rectangle(int width, int height)
{
    public int Width
    {
        get => width;
        set => Width = 10;
    }

    public int Height { get; set; } = height;

    public int GetArea()
    {
        return Height * Width;
    }

    public bool IsSquare()
    {
        return Height * Width == Height * 2;
    }
}