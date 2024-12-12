public class Supporter
{
    public string SupporterId { get; set; }

    public string Navn { get; set; }

    public int TelefonNummer { get; set; }

    public string EMail { get; set; }

    public Supporter() { }

    public Supporter (string supporterId, string navn, int telefonNummer, string eMail)
    {
        SupporterId = supporterId;
        Navn = navn;
        TelefonNummer = telefonNummer;
        EMail = eMail;
    }

}