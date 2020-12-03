using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day09 : Day
    {
        private class Group
        {
            public Group Parent { private get; set; }
            public IList<Group> Children { get; } = new List<Group>();

            public int Score => (Parent?.Score).GetValueOrDefault() + 1;

        }

        private static int Part0(string input, Func<int, int, int> responseFunc)
        {
            var groups = new List<Group>();
            Group current = null;
            var stack = new Stack<Group>();
            var isGarbage = false;
            var isEscape = false;
            var garbage = 0;

            foreach (var c in input)
            {
                if (isGarbage)
                {
                    if (isEscape)
                    {
                        isEscape = false;
                    }
                    else
                        switch (c)
                        {
                            case '!':
                                isEscape = true;
                                break;
                            case '>':
                                isGarbage = false;
                                break;
                            default:
                                ++garbage;
                                break;
                        }
                }
                else
                    switch (c)
                    {
                        case '<':
                            isGarbage = true;
                            break;
                        case '{':
                            var group = new Group
                            {
                                Parent = current
                            };
                            current?.Children.Add(group);
                            stack.Push(current);
                            groups.Add(group);
                            current = group;
                            break;
                        case '}':
                            current = stack.Pop();
                            break;
                    }
            }

            return responseFunc(groups.Sum(x => x.Score), garbage);
        }

        public override int Part1(string input)
        {
            return Part0(input, (x, y) => x);
        }

        public override long Part2(string input)
        {
            return Part0(input, (x, y) => y);
        }
    }
}
