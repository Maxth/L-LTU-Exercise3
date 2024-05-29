class NullInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use null as input in a nono-nullable field. This fired an error!";
    }
}
