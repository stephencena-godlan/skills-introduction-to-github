class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _batteryPower;
    private int _distanceTraveled;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._batteryPower = 100;
        this._distanceTraveled = 0;
    }

    public bool BatteryDrained() => ((this._batteryPower<=0) || (this._batteryPower<this._batteryDrain)) ? true : false;

    public int DistanceDriven() => this._distanceTraveled;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this._distanceTraveled += this._speed;
            this._batteryPower -= this._batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{
    private int _distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var finishedRace = false;
        
        while (!car.BatteryDrained() && (car.DistanceDriven()<=this._distance))
        {
            car.Drive();
        }

        if (car.DistanceDriven()>=this._distance) { finishedRace = true; }

        return finishedRace;
    }
}
