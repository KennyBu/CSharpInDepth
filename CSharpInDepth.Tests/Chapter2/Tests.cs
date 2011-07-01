using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Chapter2
{
    [TestClass]
    public class Tests
    {
        delegate void StringProcessor(string input);
        
        [TestMethod]
        public void can_use_delegates()
        {
            StringProcessor proc1, proc2;
            proc1 = new StringProcessor(StaticMethods.PrintString);

            var instanceMethods = new InstanceMethods();
            proc2 = new StringProcessor(instanceMethods.PrintString);

            var input = "ken test";
            
            proc1.Invoke(input);
            proc2.Invoke(input);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void type_test()
        {

            object o = "hello";
            Console.WriteLine(((string) o).Length);
        
        
            Assert.IsTrue(true);
        }
    }

    public static class StaticMethods
    {
        public static void PrintString(string x)
        {
            Console.Out.WriteLine("Static Printing {0}", x);
        }
    }

    public class InstanceMethods
    {
        public void PrintString(string x)
        {
            Console.Out.WriteLine("Instance Printing {0}", x);
        }
    }



}
