class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int n)
    {
        int minutesUsedInOver = n;
        int expected = ExpectedMinutesInOven();
        while (minutesUsedInOver <= expected)
        {
            return (expected - minutesUsedInOver);
        }

        return 0;

    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int n)
    {
        int layerspreparationtime = 2;
        int preparationtimeminutes = 0;

        for (int i = 1; i <= n; i++)
        {
            preparationtimeminutes += layerspreparationtime;
        }
        return preparationtimeminutes;
        
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int nuberoflayersadded, int minutesusedintheoven)
    {
        return ( PreparationTimeInMinutes(nuberoflayersadded) + minutesusedintheoven);
    }
}
