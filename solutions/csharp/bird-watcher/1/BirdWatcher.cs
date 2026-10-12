class BirdCount
{
    private int[] birdsPerDay;
    private int indexOfToday;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
        indexOfToday = this.birdsPerDay.Length-1;
    }

    public static int[] LastWeek() => new[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => this.birdsPerDay[indexOfToday];
    
    public void IncrementTodaysCount() => this.birdsPerDay[indexOfToday]++;

    public bool HasDayWithoutBirds()
    {
        //var result = false;
        //for(int indexBird=0; indexBird<this.birdsPerDay.Length; indexBird++)
        //{
        //    if (this.birdsPerDay[indexBird] == 0)
        //    {
        //       result = true;
        //        break;
        //    }
        //}
        //return result;
        return this.birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var totalBirds = 0;
        for (int indexBird=0; indexBird<numberOfDays; indexBird++)
        {
            totalBirds += this.birdsPerDay[indexBird];
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        var total = 0;
        for(int indexBird=0; indexBird<this.birdsPerDay.Length; indexBird++)
        {
            total += (this.birdsPerDay[indexBird]>=5) ? 1 : 0;
        }
        return total;
    }
}
