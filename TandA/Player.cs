using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandA
{
    static class Player
    {

        //Properites
        public static int PosX { get; private set; }
        public static int PosY { get; private set; }
        public static List<Item> InventoryItems { get; private set; }
        public static int Moves { get; private set; } = 0;
        private static int WeightCapacity = 6;

        public static int InventoryWeight
        {
            get
            { //TODO: finish inventory weight caluation
                return 0; }
        }

        //Public Methods
        public static void Move(string direction)
        {

        }

        public static Room GetCurrentRoom()
        {
            return null;
        }

        public static void PickUpItem(String itemName)
        {

        }

        public static void DropItem(String itemName)
        {

        }

        public static void DisplayInventory()
        {

        }
        
        public static Item GetInventoryItem(string itemName)
        {
            return null;
        }

    }
}
