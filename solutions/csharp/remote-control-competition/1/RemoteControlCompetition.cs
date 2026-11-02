// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar
{
    void Drive();
    int DistanceTravelled{get;}
}

public class ProductionRemoteControlCar : IRemoteControlCar,IComparable
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(object? otherCar)
    {
        var localCar = otherCar as ProductionRemoteControlCar;
        if (this.NumberOfVictories < localCar.NumberOfVictories) { return -1; }
        if (this.NumberOfVictories > localCar.NumberOfVictories) { return 1; }
        if (this.NumberOfVictories == localCar.NumberOfVictories) { return 0; }

        return 0;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var _list = new List<ProductionRemoteControlCar>();
        _list.Add(prc1);
        _list.Add(prc2);
        _list.Sort();
        return _list;
    }
}
