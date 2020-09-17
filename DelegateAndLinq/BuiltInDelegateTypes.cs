using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DelegateAndLinq
{
    public class BuiltInDelegateTypes
    {
        [Fact]
        public void UsingActions()
        {
            Action thingy;
            thingy = () => Console.WriteLine("Hello World");
            thingy();
            thingy = () => Console.WriteLine("Goodbye");
            thingy();

            Action<string, int> thingy2 = (message, times) =>
            {
                for (var t = 0; t < times; t++)
                {
                    Console.WriteLine(message);
                }
            };
            thingy2("WOW", 13); //This would write WOW 13 times to the console
        }

        [Fact]
        public void Funcs()
        {
            Func<int, int, int> mathOp;

            mathOp = (a, b) => a + b;
            Assert.Equal(4, mathOp(2, 2));

            mathOp = (a, b) => a * b;
            Assert.Equal(9, mathOp(3, 3));

            Func<int, bool> isEven = (x) => x % 2 == 0;

            Assert.True(isEven(4));
            Assert.False(isEven(5));

            var calculator = new Dictionary<char, Func<int, int, int>>
            {
                {'+', (a,b) => a+b },
                {'-', (a,b) => a-b },
                {'*', (a,b) => a*b },
                {'/', (a,b) => a/b },
            };
            var result = calculator['+'](2, 5); //'+' is the key and this will execute the parameters passed in
            Assert.Equal(7, result);
        }

        [Fact]
        public void Predicate()
        {
            Predicate<string> doYouLike;
            doYouLike = (what) => what == "pizza" ? true : false;

            Assert.True(doYouLike("pizza"));
            Assert.False(doYouLike("literally anythign else"));
        }
    }
}
