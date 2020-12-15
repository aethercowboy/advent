using advent.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace advent.Days._2017
{
    public class Day20 : Day
    {
        private static IList<Particle> Part0(string input)
        {
            return input.Lines().Select((line, i) => new Particle(i, line)).ToList();
        }
        public override long Part1(string input)
        {
            var particles = Part0(input);

            return particles.WithMin(x => x.Acceleration.ManhattanDistance()).First().Index;
        }

        private static IEnumerable<Particle> RemoveCollisions(ICollection<Particle> particles)
        {
            while (particles.Count > 0)
            {
                var first = particles.First();
                var collisions = particles.Where(x => Equals(x.Position, first.Position)).ToList();

                if (collisions.Count == 1)
                {
                    yield return first;
                }

                collisions.ForEach(x => particles.Remove(x));
            }
        }

        public override long Part2(string input)
        {
            var particles = Part0(input);

            foreach (var _ in Enumerable.Range(0, 1000))
            {
                foreach (var p in particles)
                {
                    p.Tick();
                }

                particles = RemoveCollisions(particles).ToList();
            }

            return particles.Count;
        }
    }

    public class Particle
    {
        public int Index { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Velocity { get; set; }
        public Vector3 Acceleration { get; set; }

        private static Vector3 Vectorize(string input, char c)
        {
            var idx = input.IndexOf(c);
            var idy = input[(idx + 3)..].IndexOf('>');

            var nums = input.Substring(idx + 3, idy).Split(',').Select(x => x.Trim()).ToInts().ToList();

            return new Vector3(nums[0], nums[1], nums[2]);
        }

        public Particle(int index, string input)
        {
            Index = index;
            Position = Vectorize(input, 'p');
            Velocity = Vectorize(input, 'v');
            Acceleration = Vectorize(input, 'a');
        }

        public int Distance => Position.ManhattanDistance();

        private static Vector3 Add(Vector3 a, Vector3 b)
        {
            return a + b;
        }

        public void Tick()
        {
            Velocity = Add(Velocity, Acceleration);
            Position = Add(Position, Velocity);
        }
    }
}
