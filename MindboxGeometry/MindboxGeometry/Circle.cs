namespace MindboxGeometry;

public class Circle : IFigure
{
    public double Radius { get; }
    
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}