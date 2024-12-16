using EksamenProjekt_1web.Pages.Models.Baseklasse;

namespace EksamenProjekt_1web.Services.Repository
{
    public abstract class Repository<T> where T : class, IHarId
    {
        private Dictionary<int, T> _data;

        public List<T> All { get { return _data.Values.ToList(); } }

        public Repository()
        {
            _data = new Dictionary<int, T>();

        }

        /// <summary>
        /// Create: Find det næste ledige Id, sæt det på det givne objekt, 
        /// og gem objektet i den interne Dictionary.
        /// </summary>
        /// <param name="t">Det objekt der nu skal gemmes i repository</param>
        public void Create(T t)
        {
            t.Id = NextId();

            _data[t.Id] = t;
        }

        /// <summary>
        /// Read: Find det objekt der matcher det givne Id, og returnér det.
        /// Hvis ikke der findes et objekt med det givne Id, returneres null.
        /// </summary>
        public T? Read(int id)
        {
            if (_data.ContainsKey(id))
            {
                return _data[id];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Delete: Prøv at slette det objekt der matcher det givne Id.
        /// </summary>
        public bool Delete(int id)
        {
            return _data.Remove(id);
        }

        /// <summary>
        /// Det næste Id udregnes ved at finde det højeste Id der 
        /// p.t. er brugt, og lægge 1 til dette.
        /// </summary>
        private int NextId()
        {
            int highestId = 0;

            foreach (int id in _data.Keys)
            {
                if (id > highestId)
                {
                    highestId = id;
                }
            }

            return highestId + 1;
        }
    }

}
