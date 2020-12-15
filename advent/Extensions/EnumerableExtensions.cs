using advent.Collections;
using advent.Days._2017;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Extensions
{
    public static class EnumerableExtensions
    {
        public static T NthOrDefault<T>(this IEnumerable<T> list, int index)
        {
            return list == null
                    ? default
                    : list.Skip(index).FirstOrDefault()
                ;
        }

        public static string AsString(this IEnumerable<int> list)
        {
            return string.Join(",", list);
        }

        public static IEnumerable<IList<string>> GenerateRoutes(this IList<string> locs)
        {
            var list = new List<IList<string>>();

            if (locs.Count == 1)
            {
                list.Add(locs);
                return list;
            }

            foreach (var loc in locs)
            {
                var subLocs = locs.Where(x => x != loc).ToList();
                foreach (var subRoute in GenerateRoutes(subLocs))
                {
                    var subList = new List<string> { loc };
                    subList.AddRange(subRoute);
                    list.Add(subList);
                }
            }

            return list;
        }

        public static IRing<T> ToRing<T>(this IEnumerable<T> collection)
        {
            return new Ring<T>(collection.ToList());
        }

        public static DancerList ToDancerList(this IEnumerable<char> collection)
        {
            return new DancerList(collection.ToList());
        }

        public static IEnumerable<T> WithMin<T>(this IEnumerable<T> collection, Func<T, int> minFunc)
        {
            var cList = collection.ToList();
            var min = cList.Min(minFunc);
            return cList.Where(x => minFunc(x) == min);
        }
    }
}