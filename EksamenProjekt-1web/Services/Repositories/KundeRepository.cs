using EksamenProjekt_1web.Services.Interfaces;

namespace EksamenProjekt_1web.Services.Repository
{
	public class KundeRepository : Repository<Kunde>, IKundeRepository
	{
		public KundeRepository()
		{
			// Mock Data
			Create(new Kunde("Navn", 123, "C"));
			Create(new Kunde("Navn2", 234, "C"));
			Create(new Kunde("Navn3", 456, "C"));
			Create(new Kunde("Navn4", 678, "C"));
		}

		public bool Update(int id, Kunde t)
		{
			if (t == null)
			{
				return false;
			}
			else
			{
				return true;
			}

		}

	}
}





/// den ned er gammel, og oppe er copied fra SagRepository med noget redigere navner

//using EksamenProjekt_1web.Services.Interfaces;

//namespace EksamenProjekt_1web.Services.Repository
//{
//    public class KundeRepository : Repository<Kunde>, IKundeRepository
//    {
// //public void Create(Kunde KundeId)
//        //{
//        //    KundeId.Id = Kunde();

//        //    _data[t.Id] = KundeId;

//        //}

//        public KundeRepository()
//        {
//            // Mock Data
//            Create(new Kunde("A", 123, "C"));
//            Create(new Kunde("A", 123, "C"));
//            Create(new Kunde("A", 123, "C"));
//            Create(new Kunde("A", 123, "C"));
//            Create(new Kunde("A", 123, "C"));
//        }
//    }
//}
