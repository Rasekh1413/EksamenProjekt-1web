using EksamenProjekt_1web.Services.Interfaces;

namespace EksamenProjekt_1web.Services.Repository
{
    public class SagRepository : Repository<Sag>, ISagRepository
    {
        public SagRepository() 
        {
            // Mock Data
            Create(new Sag("A", "B", "C", "D"));
            Create(new Sag("A", "B", "C", "D"));
            Create(new Sag("A", "B", "C", "D"));
            Create(new Sag("A", "B", "C", "D"));
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

