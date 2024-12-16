namespace EksamenProjekt_1web.Services.Interfaces
{
    public interface IKundeRepository
    {
        List<Kunde> All { get; }
        void Create(Kunde kunde);
        Kunde? Read(int id);
    }
}
