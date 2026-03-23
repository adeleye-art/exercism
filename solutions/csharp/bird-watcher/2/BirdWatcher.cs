

class BirdCount
{
    private int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this._birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return _birdsPerDay[_birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        _birdsPerDay[_birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var count in _birdsPerDay)
        {
            if (count == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        
        for (int i = 0; i < numberOfDays; i++)
        {
            sum += _birdsPerDay[i];
        }
        
        return sum;

    }

    public int BusyDays()
    {
        int count = 0;

        foreach (var day in _birdsPerDay)
        {
            if (day >= 5)
                count++;

        }
        return count;
    }
}