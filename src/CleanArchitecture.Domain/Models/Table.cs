namespace CleanArchitecture.Domain.Models;

public class Table
{
    public Table(
        double height,
        double width,
        double lenght,
        string material)
    {
        this.Height = height;
        this.Width = width;
        this.Lenght = lenght;
        this.Material = material;
    }

    public double Height { get; }
    public double Width { get; }
    public double Lenght { get; }
    public string Material { get; }
}
