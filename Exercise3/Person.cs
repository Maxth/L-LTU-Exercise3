class Person
{
    private uint _age;
    private string _fName;
    private string _lName;
    private double _height;
    private double _weight;

    public Person(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }

    public uint Age
    {
        get => _age;
        set
        {
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                throw new ArgumentException("Age must be more than zero");
            }
        }
    }
    public string FName
    {
        get => _fName;
        set
        {
            if (value.Length > 1 && value.Length < 11)
            {
                _fName = value;
            }
            else
            {
                throw new ArgumentException("Firstname need to be between 2 and 10 chars long");
            }
        }
    }
    public string LName
    {
        get => _lName;
        set
        {
            if (value.Length > 2 && value.Length < 16)
            {
                _lName = value;
            }
            else
            {
                throw new ArgumentException("Lastname need to be between 3 and 15 chars long");
            }
        }
    }
    public double Height
    {
        get => _height;
        set => _height = value;
    }
    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }
}
