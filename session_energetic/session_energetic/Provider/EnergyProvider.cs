using System;
using System.Collections.Generic;
using session_energetic.Mines;
using session_energetic.PowerPlants;

namespace session_energetic.LofaszJoska
{
    public sealed class EnergyProvider
    {
        private static EnergyProvider instance = null;
        private int energySum;

        private EnergyProvider()
        {
        }
        
        public static EnergyProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnergyProvider();
                }
                return instance;
            }
        }

        public int EnergySum
        {
            get => energySum;
            set => energySum = value;
        }

        private List<Plants> listOfPlants = new List<Plants>();

        public void addPlants(Plants plants)
        {
            listOfPlants.Add(plants);
        }


        public int createEnergySum()
        {
            for (int i = 0; i < listOfPlants.Count; i++)
            {
                listOfPlants[i].createEnergy();
                energySum += listOfPlants[i].getEnergy();
            }
            Console.WriteLine(energySum);
            return energySum;
        }

        public override string ToString()
        {
            return "Sum of daily energy: " + energySum;
        }
    }
}