using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day13 : Day
    {

        private static Firewall Part0(string input)
        {
            var firewall = new Firewall();

            foreach (var line in input.Lines())
            {
                var words = line.Words().ToList();
                var index = words[0].Trim(':').ToInt();
                var depth = words[1].ToInt();

                firewall.AddLayer(index, depth);
            }

            return firewall;
        }

        public override long Part1(string input)
        {
            var firewall = Part0(input);

            var packet = new Packet();

            var severity = 0;

            foreach (var i in Enumerable.Range(0, firewall.Size))
            {
                packet.Move();
                var layer = firewall.Layers[packet.Index];

                if (layer.ScannerIndex == 0)
                {
                    severity += i * layer.Depth;
                }

                firewall.Tick();
            }

            return severity;
        }

        public override long Part2(string input)
        {
            var firewall = Part0(input);

            var delay = Enumerable.Range(0, int.MaxValue)
                .FirstOrDefault(x =>
                {
                    return firewall.Layers.All(y => y.TimeTravel(x) != 0);
                });

            return delay;
        }
    }

    internal class Firewall
    {
        public IList<Layer> Layers { get; set; } = new List<Layer>();
        public int Size => Layers.Count;

        public void AddLayer(int index, int depth)
        {
            var count = Layers.Count;

            if (count < index)
            {
                foreach (var i in Enumerable.Range(count, index - count))
                {
                    Layers.Add(new Layer(i));
                }
            }

            var layer = new Layer(index, depth);

            Layers.Add(layer);
        }

        public void Tick()
        {
            foreach (var layer in Layers)
            {
                layer.Tick();
            }
        }

        public void Reset()
        {
            foreach (var layer in Layers)
            {
                layer.Reset();
            }
        }

        public int[] Pattern()
        {
            return Layers.Where(x => x.Scanner != null && x.ScannerIndex != null)
                .Select(x => x.ScannerIndex.Value).ToArray();
        }
    }

    internal class Layer
    {
        public int Index { get; set; }
        public Layer(int index)
        {
            Index = index;
        }

        public Layer(int index, int depth) : this(index)
        {
            Scanner = new Scanner(this);
            Depth = depth;
        }

        public Scanner Scanner { get; set; }

        public int Depth { get; protected set; }

        public void Tick()
        {
            Scanner?.Move();
        }

        public int? ScannerIndex => Scanner?.Index;

        public void Reset()
        {
            Scanner?.Reset();
        }

        public int? TimeTravel(int delay)
        {
            if (Depth == 0)
            {
                return null;
            }
            return (delay + Index) % ((Depth - 1) * 2);
        }
    }

    internal class Scanner
    {
        public Scanner(Layer layer)
        {
            Layer = layer;
        }
        
        private Layer Layer { get; set; }
        private int direction = 1;
        public int Index { get; protected set; } = 0;

        public void Move()
        {
            var next = Index + direction;

            if (next < 0 || next >= Layer.Depth)
            {
                direction *= -1;
                next = Index + direction;
            }

            Index = next;
        }

        public void Reset()
        {
            direction = 1;
            Index = 0;
        }
    }

    internal class Packet
    {
        public int Index { get; protected set; } = -1;

        public void Move()
        {
            ++Index;
        }

        public void Reset()
        {
            Index = -1;
        }
    }
}