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
    }
}
