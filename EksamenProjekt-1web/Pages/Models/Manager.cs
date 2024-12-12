public class Manager
{
    public string ManagerId { get; set; }

    public string Navn { get; set; }



    public Manager() { }

    public Manager (string managerId, string navn)
    {
        ManagerId = managerId;
        Navn = navn;
    }



}