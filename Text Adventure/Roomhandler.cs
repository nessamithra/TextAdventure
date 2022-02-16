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
            int roomnr = r.Next(Enum.GetNames(typeof(RoomNames)).Length);
            switch (roomnr)
            {
                case (int)RoomNames.CHEST:
                    return new ChestRoom();
                case (int)RoomNames.ENEMY:
                    return new EnemyRoom();
                default:
                    throw new Exception("Could not gernerate room");
            }
        }
    }
}