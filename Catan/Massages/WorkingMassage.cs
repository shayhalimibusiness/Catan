namespace Catan.Massages;

public class WorkingMassage : IMassage
{
    public WorkingMassage(string massage)
    {
        Massage = massage;
    }

    public string Massage { get; set; }
    
    public override string? ToString()
    {
        return Massage;
    }
}