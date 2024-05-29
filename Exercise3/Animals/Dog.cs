class Dog(string name, int age, double weight, double maxBarkDecibel) : Animal(name, age, weight)
{
    public double MaxBarkDecibel { get; set; } = maxBarkDecibel;

    public override void DoSound()
    {
        System.Console.WriteLine("Voff");
    }

    public override string Stats()
    {
        return base.Stats() + $"MaxBarkDecibel: {MaxBarkDecibel}";
    }

    public string Pee()
    {
        return "Peeing...";
    }
}
