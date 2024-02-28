// See https://aka.ms/new-console-template for more information


using DesingPatternExamples.BuilderDesingPattern.Abstract;
using DesingPatternExamples.BuilderDesingPattern.Concrete;
using DesingPatternExamples.BuilderDesingPattern.NewDirectory1;

CarBuilder opel = new OpelConcreteBuilder();
opel.SetBrand();
opel.SetGear();
opel.SetKm();
opel.SetModel();

Console.WriteLine(opel.Car);