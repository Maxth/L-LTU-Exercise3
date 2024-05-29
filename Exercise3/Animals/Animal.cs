abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public double Weight { get; set; }

    public Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public abstract void DoSound();

    public virtual string Stats()
    {
        return $"Name: {Name} Age: {Age} Weight: {Weight} ";
    }
}
