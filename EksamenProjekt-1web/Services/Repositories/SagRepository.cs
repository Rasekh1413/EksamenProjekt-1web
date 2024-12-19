using EksamenProjekt_1web.Services.Interfaces;

namespace EksamenProjekt_1web.Services.Repository
{
    public class SagRepository : Repository<Sag>, ISagRepository
    {
        public SagRepository() 
        {
            // Mock Data
            Create(new Sag("Medina", "medina@email.dk", "+123456789", "2"));
            Create(new Sag("Rasekh", "rasekh@email.dk", "+123456789", "7"));
            Create(new Sag("Tobias", "tobias@email.dk", "+123456789", "1"));
            Create(new Sag("Elizabeth", "elizabeth@email.dk", "+123456789", "4"));
            Create(new Sag("Aya", "aya@email.dk", "+123456789", "4"));
        }

        public bool Update(int id, Sag t)
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

