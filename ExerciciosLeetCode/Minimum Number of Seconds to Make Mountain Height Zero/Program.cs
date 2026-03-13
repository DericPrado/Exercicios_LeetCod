internal class Program
{
    static void Main(string[] args)
    {
        /*
            Segue o desafio: https://leetcode.com/problems/minimum-number-of-seconds-to-make-mountain-height-zero/description/?envType=daily-question&envId=2026-03-13
         */
    }
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
    {
        long left = 1;

        long minBaseTime = workerTimes.Min();
        long right = minBaseTime * (long)mountainHeight * (mountainHeight + 1) / 2;

        long bestTime = right;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;

            if (CanReduceMountain(mid, mountainHeight, workerTimes))
            {
                bestTime = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return bestTime;
    }

    private bool CanReduceMountain(long timeLimit, int mountainHeight, int[] workerTimes)
    {
        long totalReduced = 0;

        foreach (int t in workerTimes)
        {
            totalReduced += GetMaxMetrosForWorker(timeLimit, t, mountainHeight);

            if (totalReduced >= mountainHeight)
            {
                return true;
            }
        }

        return false;
    }

    private long GetMaxMetrosForWorker(long timeLimit, long baseTime, int maxPossibleHeight)
    {
        long low = 0;
        long high = maxPossibleHeight;
        long maxMetros = 0;

        while (low <= high)
        {
            long mid = low + (high - low) / 2;

            long timeNeeded = baseTime * mid * (mid + 1) / 2;

            if (timeNeeded <= timeLimit)
            {
                maxMetros = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return maxMetros;
    }
}