using System;
using session_energetic.EnergyConsumers;
using session_energetic.Mines;
using session_energetic.PowerPlants;
using session_energetic.LofaszJoska;

namespace session_energetic
{
    class Program
    {
        static void Main(string[] args)
        {
            CoalMine cm = new CoalMine();
            /*CoalPlant cp = new CoalPlant();
            SolarPlant sp = new SolarPlant();*/
            Plants cp = PlantFactory.CreatePlant(PlantType.Coal);
            Plants sp = PlantFactory.CreatePlant(PlantType.Solar);
            EnergyProvider ep = EnergyProvider.Instance;
            ep.addPlants(cp);
            ep.addPlants(sp);
            NewYork ny = new NewYork(ep);

            for (int i = 0; i < 14; i++)
            {
                cm.Production();
                cp.createEnergy();
                sp.createEnergy();
                ep.createEnergySum();
                ny.enoughEnergy();
            }
        }
    }
}