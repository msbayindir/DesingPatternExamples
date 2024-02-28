using DesingPatternExamples.BuilderDesingPattern.Model;

namespace DesingPatternExamples.BuilderDesingPattern.Abstract;

public abstract class CarBuilder
{
    protected Car car;
    public Car Car => car;
    public abstract void SetBrand();
    public abstract void SetModel();
    public abstract void SetKm();
    public abstract void SetGear();

}