using Xunit;
using MonorepoWithCSharpRust.Math;

namespace MonorepoWithCSharpRust.Tests;

public class FFITest
{
    [Fact]
    public void RustAddTest()
    {
        Assert.Equal(2, MonorepoWithCSharpRust.Math.API.RustAdd(1, 1));
    }

    [Fact]
    public void RustLengthTest()
    {
        var vec = new RustVector2D
        {
            X = 3,
            Y = 4
        };
        Assert.Equal(5.0, MonorepoWithCSharpRust.Math.API.RustLength(vec));
        Assert.Equal(3.0, vec.X);
        Assert.Equal(4.0, vec.Y);
    }
}