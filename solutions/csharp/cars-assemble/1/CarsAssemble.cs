static class AssemblyLine
{
    public static bool Between(this int value, int min, int max) => ((value>=min) && (value<=max));
    
    public static double SuccessRate(int speed)
    {
        if (speed.Between(1,4)) { return 1d; }
        if (speed.Between(5,8)) { return .9d; }
        if (speed == 9) {return .8d; }
        if (speed == 10) { return .77d; }

        return 0d;
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => ((int)ProductionRatePerHour(speed))/60;
}