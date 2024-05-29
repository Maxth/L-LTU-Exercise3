class Flamingo(string name, int age, double weight, double wingSpan, double legLength)
    : Bird(name, age, weight, wingSpan)
{
    public double LegLength { get; set; } = legLength;

    public override string Stats()
    {
        return base.Stats() + $"LegLength: {LegLength}";
    }
}
