using System;

namespace Text_Adventure
{
    public class Roomhandler
    {
        private Random r;
        public enum RoomNames
        {
            CHEST,
            ENEMY,
            WITCH
        }

        public Roomhandler()
        {
            r = new Random();
        }

        public Room getRoom(ref Character chara)
        {
            int temp = r.Next(100);
            int roomnr = 0;
            if (temp < 75)
            {
                roomnr = 1;
            }

            if (temp > 80)
            {
                roomnr = 2;
            }
            switch (roomnr)
            {
                case (int)RoomNames.CHEST:
                    return new ChestRoom(ref chara);
                case (int)RoomNames.ENEMY:
                    return new EnemyRoom(ref chara);
                case (int)RoomNames.WITCH:
                    return new WitchRoom(ref chara);
                default:
                    throw new Exception("Could not generate room");
            }
        }
    }
}