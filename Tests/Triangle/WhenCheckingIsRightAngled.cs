using FluentAssertions;
using NUnit.Framework;

namespace Tests.Triangle;

public class WhenCheckingIsRightAngled : TestBase
{
    [Test]
    public void RightAngledTriangle()
    {
        var triangle = new MindboxGeometry.Triangle(9, 15, 12);

        var isRightAngled = triangle.CheckIsRightAngled();

        isRightAngled.Should().BeTrue();
    }

    [Test]
    public void NotRightAngled()
    {
        var triangle = new MindboxGeometry.Triangle(15, 13, 17);

        var isRightAngled = triangle.CheckIsRightAngled();

        isRightAngled.Should().BeFalse();
    }
}