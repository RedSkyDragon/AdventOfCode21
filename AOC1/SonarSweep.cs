namespace AOC1
{
    public static class SonarSweep
    {
        //Puzzle 1 solution
        public static int CountIncreasesSimple(List<int> measurements)
        {
            if (measurements.Count < 2)
            {
                throw new ArgumentException("There is not enough data.");
            }

            var increases = 0;
            for (int i = 1; i < measurements.Count; i++)
            {
                if (measurements[i] > measurements[i - 1])
                {
                    increases++;
                }
            }

            return increases;
        }

        //Puzzle 2 solution
        public static int CountIncreasesWindow(List<int> measurements, int windowSize)
        {
            if (measurements.Count < windowSize + 1)
            {
                throw new ArgumentException("There is not enough data.");
            }

            var increases = 0;
            var prevSum = measurements.Take(windowSize).Sum();

            for (int i = 1; i < measurements.Count - (windowSize - 1); i++)
            {
                var currentSum = measurements.Skip(i).Take(windowSize).Sum();

                if (currentSum > prevSum)
                {
                    increases++;
                }

                prevSum = currentSum;
            }

            return increases;
        }
    }
}
