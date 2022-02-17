using System;

namespace Text_Adventure
{
    public class Roomhandler
    {
        private Random r;
        public enum RoomNames
        {
            CHEST,
            ENEMY
        }

        public Roomhandler()
        {
            r = new Random();
        }

        public Room getRoom()
        {
            int temp = r.Next(100);
            int roomnr = 0;
            if (temp <75)
            {
                roomnr = 1;
            }
            switch (roomnr)
            {
                case (int)RoomNames.CHEST:
                    return new ChestRoom();
                case (int)RoomNames.ENEMY:
                    return new EnemyRoom();
                default:
                    throw new Exception("Could not generate room");
            }
        }
    }
}