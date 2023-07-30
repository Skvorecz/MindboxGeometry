namespace MindboxGeometry;

public class Triangle : IFigure
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
 
    
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double GetArea()
    {
        var perimeter = A + B + C;
        var halfPerimeter = perimeter / 2;
        
        var square = Math.Sqrt(
                        halfPerimeter 
                        * (halfPerimeter - A)
                        * (halfPerimeter - B)
                        * (halfPerimeter - C));

        return square;
    }

    public bool CheckIsRightAngled()
    {
        var sides = new[]{ A, B, C };
        Array.Sort(sides);

        var squaredHypotenuse = sides[2] * sides[2];
        var squaredFirstLeg = sides[0] * sides[0];
        var squaredSecondLeg = sides[1] * sides[1];

        return Math.Abs(squaredHypotenuse - (squaredFirstLeg + squaredSecondLeg)) < 1e-10;
    }
}