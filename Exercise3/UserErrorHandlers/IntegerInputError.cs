class IntegerInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use an integer input in a double only field. This fired an error!";
    }
}
