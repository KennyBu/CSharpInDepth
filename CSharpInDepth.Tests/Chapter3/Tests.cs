using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Chapter3
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void can_test_listing_3_1()
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";

            Dictionary<string, int> frequencies = CountWords(text);
            foreach (KeyValuePair<string,int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0}: {1}",word,frequency);
            }

            Assert.IsTrue(true);
        }

        static Dictionary<string,int> CountWords(string text)
        {
            Dictionary<string, int> frequncies;
            frequncies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");

            foreach (var word in words)
            {
                if (frequncies.ContainsKey(word))
                {
                    frequncies[word]++;
                }
                else
                {
                    frequncies[word] = 1;
                }
            }

            return frequncies;
        }


        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        [TestMethod]
        public void can_test_listing_3_2()
        {
            List<int> integers = new List<int>();
            
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);

            Converter<int, double> converter = TakeSquareRoot;

            List<double> doubles;
            doubles = integers.ConvertAll<double>(converter);
            foreach (var d in doubles)
            {
                Console.WriteLine(d);
            }

            
            
            Assert.IsTrue(true);
        }

        static List<T> MakeList<T>(T first,T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }

        [TestMethod]
        public void can_test_listing_3_3()
        {
            List<string> list = MakeList<string>("Line 1", "Line 2");
            foreach (string x in list)
            {
                Console.WriteLine(x);
            }

            Assert.IsTrue(true);
        }

    }
}
