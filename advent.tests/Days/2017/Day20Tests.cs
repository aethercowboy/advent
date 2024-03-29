﻿using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day20Tests : DayTests<Day20>
    {
        [Fact]
        public void Test01()
        {
            const string input = @"p=< 3,0,0>, v=< 2,0,0>, a=<-1,0,0>
p=< 4,0,0>, v=< 0,0,0>, a=<-2,0,0>";
            var result = Client.Part1(input);
            Assert.Equal(0.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            const string input = @"p=<-6,0,0>, v=< 3,0,0>, a=< 0,0,0>    
p=<-4,0,0>, v=< 2,0,0>, a=< 0,0,0>
p=<-2,0,0>, v=< 1,0,0>, a=< 0,0,0>
p=< 3,0,0>, v=<-1,0,0>, a=< 0,0,0>";
            var result = Client.Part2(input);
            Assert.Equal(1.ToString(), result);
        }
    }
}
