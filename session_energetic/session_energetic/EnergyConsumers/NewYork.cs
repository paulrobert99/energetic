using System;
using session_energetic.LofaszJoska;

namespace session_energetic.EnergyConsumers
{
    public class NewYork
    {
        private int supply_needed = 100;
        private EnergyProvider _energyProvider;

        public NewYork(EnergyProvider energyProvider)
        {
            _energyProvider = energyProvider;
        }

        public void enoughEnergy()
        {
            if (_energyProvider.EnergySum >= supply_needed)
            {
                Console.WriteLine("Sufficient level of energy");
                _energyProvider.EnergySum -= supply_needed;
            }
            else
            {
                Console.WriteLine("Not enough energy");
            }
        }

    }
}