
using Moq;
using System;
using Xunit;

namespace MoqTrainning
{
    public interface IFoo
    {
        Bar bar { get; set; }
        string Name { get; set; }
        int Value { get; set; }
        bool DoSomething(string value);
        bool DoSomething(int number, string value);
        string DoSomethingStringy(string value);
        bool TryParse(string value, out string outputValue);
        bool Submit(ref Bar bar);
        int GetCount();
        bool Add(int value);
    }
    public class Bar
    {
        public virtual Baz Baz { get; set; }
        public virtual bool Submit() { return false; }
    }

    public class Baz
    {
        public virtual string Name { get; set; }
    }

    public class Test
    {
        [Fact]
        public void Test1()
        {
            Mock<IFoo> mock = new Mock<IFoo>();
            mock.Setup(foo => foo.DoSomething("ping")).Returns(true);

            //out arguments
            var outString = "ack";
            //TryParse will return true, and the out argument will return "ack", lazy evaluation
            mock.Setup(foo => foo.TryParse("ping", out outString))
                .Returns(true);

            //ref arguments
            var instance = new Bar();
            //Only matches it the ref argument to the invacation is the same instance
            mock.Setup(foo => foo.Submit(ref instance))
                .Returns(true);

            //access invocation arguments when returning a value
            mock.Setup(x => x.DoSomethingStringy(It.IsAny<string>()))
                .Returns((string s) => s.ToLower());

            //throwing when invoked with specific parameters
            mock.Setup(foo => foo.DoSomething("reset"))
                .Throws<InvalidOperationException>();
            mock.Setup(foo => foo.DoSomething(""))
                .Throws(new ArgumentException("command"));

            //lazy evaluation returns value
            var count = 1;
            mock.Setup(foo => foo.GetCount())
                .Returns(() => count);

        }
    }


}

