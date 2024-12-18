// her ned er fra Rasekh hjælp

namespace EksamenProjekt_1web.MockSag
{
    public class MockSager
    {
        public static List<Sag> Sag { get; }
        public static List<Kunde> Kunder { get; }

        static MockSager()
        {
            Sag = new List<Sag>
            {
                new Sag()
            };

            Kunder = new List<Kunde>();
        }
    }
}