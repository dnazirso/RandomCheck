using System;
using System.Linq;

namespace FunctionSpace
{
    public class Calculation
    {
        double[] Accumulator { get; set; }
        public int[] Graph { get; }
        int NbSamples { get; set; }
        int NbSegments { get; set; }

        public Calculation(int NbSamples, int NbSegments)
        {
            this.NbSamples = NbSamples;
            this.NbSegments = NbSegments;
            Accumulator = new double[NbSamples];
            Graph = new int[NbSegments];

            Cumulate();
            CountSegment();
        }

        void Cumulate()
        {
            for (int i = 0; i < NbSamples; i++)
            {
                Accumulator[i] = ThreadSafeRandom.Rand();
            }
        }

        void CountSegment()
        {
            Array.Sort(Accumulator);

            double max = Accumulator.Max();
            double min = Accumulator.Min();

            double distance = max - min;
            double segment = distance / NbSegments;

            for (int i = 0; i < NbSegments; i++)
            {
                foreach (double a in Accumulator)
                {
                    if (a < min + (segment * (i + 1)) && a > min + (segment * (i)))
                    {
                        Graph[i]++;
                    }
                }
            }
        }
    }
}
