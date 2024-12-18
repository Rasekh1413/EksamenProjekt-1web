
using System.Xml.Linq;

public class Sag : HarId
{
	public string FejlBeskrivelse { get; set; }
    public string Modelår { get; set; }
    public string ModelType { get; set; }
    public string NummerPlade { get; set; }

 
    public Sag(string fejlBeskrivelse, string modelår, string modelType, string nummerPlade)
    {
        FejlBeskrivelse=fejlBeskrivelse;
        Modelår=modelår;
        ModelType=modelType;
        NummerPlade=nummerPlade;
    }
	public Sag()
        // NB: Nødvendig fordi vi er i en Razor Pages app.
	{
	
	}

}


