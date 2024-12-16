public class Supporter : HarId
{ 

    public string Navn { get; set; }

    public int TelefonNummer { get; set; }

    public string EMail { get; set; }

    public Supporter() { }

    public Supporter (string navn, int telefonNummer, string eMail)
    {
        Navn = navn;
        TelefonNummer = telefonNummer;
        EMail = eMail;
    }

}