namespace DesingPatternExamples.BuilderDesingPattern.Model;

public record Car
{
    public string Barnd { get; set; }
    public string Model { get; set; }
    public double KM { get; set; }
    public bool Gear { get; set; }
}