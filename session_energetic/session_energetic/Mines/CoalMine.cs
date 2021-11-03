using System;

namespace session_energetic.Mines
{
    public class CoalMine
    {
        private static int coal = 0;

        public static int Coal
        {
            get => coal;
            set => coal = value;
        }

        public void Production()
        {
            for (int i = 0; i < 100; i++)
            {
                coal += 40;
            }

        }
        

        public override string ToString()
        {
            return "Coal: " + coal;
        }
    }
}