public class Kunde : HarId
{
   

    public string Navn { get; set; }

    public int TelefonNummer { get; set; }

    public string EMail { get; set; }

    public Kunde() { }

    public Kunde(string navn, int telefonummer, string eMail)
    {
        Navn = navn;
        TelefonNummer = telefonummer;
        EMail = eMail;
    }

 
}