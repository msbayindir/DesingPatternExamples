using DesingPatternExamples.BuilderDesingPattern.Abstract;
using DesingPatternExamples.BuilderDesingPattern.Model;

namespace DesingPatternExamples.BuilderDesingPattern.Concrete;

public class BmwConcreteBuilder:CarBuilder
{
    public BmwConcreteBuilder()
    {
        car = new Car();
    }
    public override void SetBrand() => car.Barnd = "BMW";
    public override void SetModel() => car.Model = "XSX124XSSFCX";
    public override void SetKm() => car.KM = 1071;
    public override void SetGear() => car.Gear = true;

}