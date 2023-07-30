using FluentAssertions;
using NUnit.Framework;

namespace Tests.Circle;

public class WhenGettingArea : TestBase
{
    [Test]
    public void AreaCalculatedCorrectly()
    {
        var circle = new MindboxGeometry.Circle(2);

        var area = circle.GetArea();

        area.Should().Be(12.566370614359172);
    }
}