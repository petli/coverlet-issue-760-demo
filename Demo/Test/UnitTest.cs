using System;
using System.Threading.Tasks;
using Demo;
using Xunit;

namespace Test
{
    public class UnitTest
    {
        [Fact]
        public async Task TestIf()
        {
            var result = await Implementation.If();
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task TestForeach()
        {
            var result = await Implementation.Foreach();
            Assert.Equal(30, result);
        }
    }
}
