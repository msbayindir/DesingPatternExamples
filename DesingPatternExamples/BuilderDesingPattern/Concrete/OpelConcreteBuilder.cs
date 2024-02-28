using DesingPatternExamples.BuilderDesingPattern.Abstract;

namespace DesingPatternExamples.BuilderDesingPattern.Concrete;

public class OpelConcreteBuilder:CarBuilder
{
    public OpelConcreteBuilder()
    {
        car = new();
    }
    public override void SetBrand() => car.Barnd = "Opel";
    public override void SetModel() => car.Model = "Astra";
    public override void SetKm() => car.KM = 100;
    public override void SetGear() => car.Gear = true;

}