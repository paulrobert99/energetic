namespace session_energetic.PowerPlants
{
    public class SolarPlant : Plants
    {
        private int solarenergy;

        public int Energy
        {
            get => solarenergy;
            set => solarenergy = value;
        }

        public override void createEnergy()
        {
            solarenergy = 0;
            for (int i = 0; i < 10; i++)
            {
                Energy += 2;
            }
        }

        public override int getEnergy()
        {
            return solarenergy;
        }

    }
}