using System;
using Xunit;

namespace RustFFI.Tests
{
    public class ModuleTests
    {
        [Fact]
        public void RustAddTest()
        {
            Assert.Equal(2, Module.RustAdd(1, 1));
        }

        [Fact]
        public void RustLengthTest()
        {
            var vec = new RustVector2D
            {
                X = 3,
                Y = 4
            };
            Assert.Equal(5.0, Module.RustLength(vec));
            Assert.Equal(3.0, vec.X);
            Assert.Equal(4.0, vec.Y);
        }
    }
}
