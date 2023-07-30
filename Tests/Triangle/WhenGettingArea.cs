using FluentAssertions;
using NUnit.Framework;

namespace Tests.Triangle;

public class WhenGettingArea : TestBase
{
    [Test]
    public void AreaCalculatedCorrectly()
    {
        var triangle = new MindboxGeometry.Triangle(15, 13, 17);

        var area = triangle.GetArea();

        area.Should().Be(93.89988019161686);
    }
}