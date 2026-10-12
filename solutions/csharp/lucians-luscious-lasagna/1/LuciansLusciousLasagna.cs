class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int currentTimeInOven) => ExpectedMinutesInOven() - currentTimeInOven;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) => 2 * numberOfLayers;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int currentTimeInOven) => PreparationTimeInMinutes(numberOfLayers) + currentTimeInOven;
   
}