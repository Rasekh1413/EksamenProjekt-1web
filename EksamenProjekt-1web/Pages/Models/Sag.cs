
public class Sag
{

    public string SagId { get; set; }

    public string SagFejlBeskrivelse { get; set; }

    public string SagModelår { get; set; }

    public string SagModelType { get; set; }

    public string SagNummerPlade { get; set; }

    public Sag() { }

    public Sag(string sagId, string sagFejlBeskrivelse, string sagModelår, string sagModelType, string sagNummerPlade)
    {
        SagId=sagId;
        SagFejlBeskrivelse=sagFejlBeskrivelse;
        SagModelår=sagModelår;
        SagModelType=sagModelType;
        SagNummerPlade=sagNummerPlade;
    }
}