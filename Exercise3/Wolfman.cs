class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, int age, double weight, int killCount)
        : base(name, age, weight, killCount) { }

    public void Talk()
    {
        System.Console.WriteLine($"I've killed {KillCount} creatures");
    }
}
