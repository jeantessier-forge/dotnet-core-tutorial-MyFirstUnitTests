using System;
using Xunit;
 
namespace xUnit_Test
{
    public class xUnit_Tests : IDisposable
    {
        public xUnit_Tests()
        {
            Console.WriteLine("Inside Fixture Constructor");
        }
 
        public void Dispose()
        {
            Console.WriteLine("Inside Fixture Dispose method");
        }
    }
 
    public class UnitTest_1 : IClassFixture<xUnit_Tests>, IDisposable
    {
        public UnitTest_1()
        {
            Console.WriteLine("Inside UnitTest_1 Constructor");
        }

        [Fact]
        public void Test_1()
        {
            Console.WriteLine("Inside Test_1");
        }
 
        public void Dispose()
        {
            Console.WriteLine("Inside UnitTest_1 Dispose method");
        }
    }

    public class UnitTest_2 : IClassFixture<xUnit_Tests>, IDisposable
    {
        public UnitTest_2()
        {
            Console.WriteLine("Inside UnitTest_2 Constructor");
        }

        [Fact]
        public void Test_2()
        {
            Console.WriteLine("Inside Test_2");
        }
 
        public void Dispose()
        {
            Console.WriteLine("Inside UnitTest_2 Dispose method");
        }
    }
}

