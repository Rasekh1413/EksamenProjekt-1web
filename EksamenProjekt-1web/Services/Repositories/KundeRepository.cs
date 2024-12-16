using EksamenProjekt_1web.Services.Interfaces;

namespace EksamenProjekt_1web.Services.Repository
{
    public class KundeRepository : Repository<Kunde>, IKundeRepository
    {
        //public void Create(Kunde KundeId)
        //{
        //    KundeId.Id = Kunde();

        //    _data[t.Id] = KundeId;

        //}

        public KundeRepository()
        {
            // Mock Data
            Create(new Kunde("A", 123, "C"));
            Create(new Kunde("A", 123, "C"));
            Create(new Kunde("A", 123, "C"));
            Create(new Kunde("A", 123, "C"));
            Create(new Kunde("A", 123, "C"));
        }
    }
}
