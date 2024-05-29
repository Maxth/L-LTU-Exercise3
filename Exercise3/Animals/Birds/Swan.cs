class Swan(string name, int age, double weight, double wingSpan, int agressivenessRating)
    : Bird(name, age, weight, wingSpan)
{
    public int AgressivenessRating { get; set; } = agressivenessRating;

    public override string Stats()
    {
        return base.Stats() + $"AgressivenessRating: {AgressivenessRating}";
    }
}
