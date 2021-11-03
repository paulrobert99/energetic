using System;
using session_energetic.Mines;

namespace session_energetic.PowerPlants
{
    class CoalPlant : Plants
    {
        private int energy;

        public int Energy
        {
            get => energy;
            set => energy = value;
        }

        public override void createEnergy()
        {
            energy = 0;
            for (int i = 0; i < 10; i++)
            {
                if (CoalMine.Coal >= 100)
                {
                    energy += 7;
                    CoalMine.Coal -= 100;
                }
            }
        }

        public override int getEnergy()
        {
            return energy;
        }

        public override string ToString()
        {
            return "Energy: " + energy;
        }
    }
}