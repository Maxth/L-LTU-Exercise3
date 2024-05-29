class Hedgehog(string name, int age, double weight, int spikeCount) : Animal(name, age, weight)
{
    public int SpikeCount { get; set; } = spikeCount;

    public override void DoSound()
    {
        System.Console.WriteLine("Prassel");
    }

    public override string Stats()
    {
        return base.Stats() + $"SpikeCount: {SpikeCount}";
    }
}
