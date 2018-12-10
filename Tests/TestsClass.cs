using ClassLib;
using System;
using Xunit;

namespace Tests
{
    public class TestsClass
    {
        [Fact]
        public void Test1()
        {
            var methods = new MethodsClass();
            Assert.Equal(4, methods.Add(2, 2));
        }

        [Fact]
        public void Test2()
        {
            var methods = new MethodsClass();
            Assert.Equal(4,  methods.Add(2, 2));
        }

    }
}
