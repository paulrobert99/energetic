namespace session_energetic.PowerPlants
{
    public class PlantFactory
    {
        public static Plants CreatePlant(PlantType plantType)
        {
            switch (plantType)
            {
                case PlantType.Coal: return new CoalPlant();
                case PlantType.Solar: return new SolarPlant();
            }

            return null;
        }
    }


}