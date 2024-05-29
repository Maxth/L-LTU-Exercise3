class Pelican(string name, int age, double weight, double wingSpan, double beakLength)
    : Bird(name, age, weight, wingSpan)
{
    public double BeakLength { get; set; } = beakLength;

    public override string Stats()
    {
        return base.Stats() + $"BeakLength: {BeakLength}";
    }
}
