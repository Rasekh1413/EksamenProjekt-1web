namespace EksamenProjekt_1web.Services.Interfaces
{
    public interface ISagRepository
    {
        List<Sag> All { get; }
        void Create(Sag sag);
        Sag? Read(int id);

        bool Update(int id, Sag sag);
    }
}
