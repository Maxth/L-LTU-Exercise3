class Bird(string name, int age, double weight, double wingSpan) : Animal(name, age, weight)
{
    public double Wingspan { get; set; } = wingSpan;

    public override void DoSound()
    {
        System.Console.WriteLine("Kvitter");
    }

    public override string Stats()
    {
        return base.Stats() + $"WingSpan: {Wingspan} ";
    }
}
