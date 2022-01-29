using System;
using Xunit;
 
namespace xUnit_Test
{
    public class Callable
    {
        public int CallCount { get; private set; }

        public void Call()
        {
            CallCount = CallCount + 1;
        }
    }

    public class CallableFixture : Callable, IDisposable
    {
        public CallableFixture()
        {
            Console.WriteLine("Inside Fixture Constructor");
        }
 
        public void Dispose()
        {
            Console.WriteLine("Inside Fixture Dispose method");
        }
    }
 
    public class UnitTest_1 : Callable, IClassFixture<CallableFixture>, IDisposable
    {
        private CallableFixture fixture;

        public UnitTest_1(CallableFixture fixture)
        {
            this.fixture = fixture;
            Console.WriteLine("Inside UnitTest_1 Constructor");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Test_1(int testNumber)
        {
            fixture.Call();
            Call();
            Console.WriteLine($"Inside Test_1 #{testNumber}: this.CallCount = {this.CallCount}, fixture.CallCount = {fixture.CallCount}");
        }
 
        public void Dispose()
        {
            Console.WriteLine("Inside UnitTest_1 Dispose method");
        }
    }

    public class UnitTest_2 : Callable, IClassFixture<CallableFixture>, IDisposable
    {
        private CallableFixture fixture;

        public UnitTest_2(CallableFixture fixture)
        {
            this.fixture = fixture;
            Console.WriteLine("Inside UnitTest_2 Constructor");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Test_2(int testNumber)
        {
            fixture.Call();
            Call();
            Console.WriteLine($"Inside Test_2 #{testNumber}: this.CallCount = {this.CallCount}, fixture.CallCount = {fixture.CallCount}");
        }
 
        public void Dispose()
        {
            Console.WriteLine("Inside UnitTest_2 Dispose method");
        }
    }
}

