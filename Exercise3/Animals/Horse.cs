class Horse(string name, int age, double weight, double maxSpeed) : Animal(name, age, weight)
{
    public double MaxSpeed { get; set; } = maxSpeed;

    public override void DoSound()
    {
        System.Console.WriteLine("Gnägg");
    }

    public override string Stats()
    {
        return base.Stats() + $"MaxSpeed: {MaxSpeed}";
    }
}
