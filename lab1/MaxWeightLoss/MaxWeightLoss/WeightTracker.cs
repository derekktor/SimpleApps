using System;
namespace MaxWeightLoss
{
    public class WeightTracker
    {
        int _days;
        int[] _weights;

        public WeightTracker(int[] weights)
        {
            _days = weights.Length;
            _weights = weights;
        }

        public int GetMaxDiff()
        {
            int maxDiff = 0;
            for (int i = 0; i < _days - 1; i++)
            {
                for (int j = i + 1; j < _days; j++)
                {
                    int sub = _weights[i] - _weights[j];
                    if (sub > maxDiff)
                    {
                        maxDiff = sub;
                    }
                }
            }

            return maxDiff;
        }

        public void GetInfo()
        {
            string output = "";
            output += "Days:\t" + _days.ToString() + "\n";
            output += "Weights:\n\t";
            foreach (int w in _weights)
            {
                output += w + " ";
            }
            Console.WriteLine(output);
        }
    }
}
