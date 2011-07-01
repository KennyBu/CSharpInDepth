using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Chapter2
{
     [TestClass]
    public class SimpleDelegateTests
     {
         private delegate void StringProcessor(string input);

         class Person
         {
             private readonly string _name;

             public Person(string name)
             {
                _name = name;
             }
             
             public void Say(string message)
             {
                 Console.Out.WriteLine("{0} says: {1}",_name,message);
             }
         }

         class Background
         {
             public static void Note(string note)
             {
                 Console.Out.WriteLine("({0})", note);
             }
         }
         
         [TestMethod]
         public void test_a_simple_delegate()
         {
             var jon = new Person("Jon");
             var tom = new Person("Tom");
             StringProcessor jonsVoice, tomsVoice, background;
             jonsVoice = new StringProcessor(jon.Say);
             tomsVoice = new StringProcessor(tom.Say);
             background = new StringProcessor(Background.Note);

             jonsVoice("Hello, son.");
             tomsVoice.Invoke("Hello, daddy!");
             background.Invoke("An airplane flies past.");

             Assert.IsTrue(true);

         }
    }
}