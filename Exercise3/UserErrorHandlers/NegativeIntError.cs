class NegativeIntError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use a negative integer input in a field that only accepts positive integers. This fired an error!";
    }
}
