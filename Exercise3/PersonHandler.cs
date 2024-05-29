class PersonHandler
{
    public void SetAge(Person pers, uint age)
    {
        pers.Age = age;
    }

    public void SetWeight(Person pers, double weight)
    {
        pers.Weight = weight;
    }

    public void SetHeight(Person pers, double height)
    {
        pers.Height = height;
    }

    public Person CreatePerson(uint age, string fname, string lname, double height, double weight)
    {
        return new Person(fname, lname)
        {
            Age = age,
            Height = height,
            Weight = weight
        };
    }
}
