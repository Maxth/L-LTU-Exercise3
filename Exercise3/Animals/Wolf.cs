class Wolf(string name, int age, double weight, int killCount) : Animal(name, age, weight)
{
    public int KillCount { get; set; } = killCount;

    public override void DoSound()
    {
        System.Console.WriteLine("Yl");
    }

    public override string Stats()
    {
        return base.Stats() + $"KillCount: {KillCount}";
    }
}
