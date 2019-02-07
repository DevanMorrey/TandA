using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandA
{
    class Room 
    {
        //Variables
        private List<string> exits;


        // Properties
        public string Title { get;private set; }

        public string Description { get;private set; }

        public List<Item> Items { get;private set; }


        #region Public Methods
        // Public Methods

        public void Describe()
        {
            TextBuffer.Add(this.Description);
            TextBuffer.Add(this.GetItemList());
            TextBuffer.Add(this.GetExitList());
        }

        public void ShowTitle()
        {
            TextBuffer.Add(this.Title);
        }

        public Item GetItem(string itemName)
        {
            foreach (Item item in Items)
            {

                if (item.Title.ToLower() == itemName.ToLower())
                {
                    return item;
                }
                return null;

            }

            return null;
        }

        public void AddExit(string direction)
        {
            if (exits.IndexOf(direction) == -1)
            {
                //Exit does not exist yet
                exits.Add(direction);
            }

        }

        public void RemoveExit(string direction)
        {
            if (exits.IndexOf(direction) != -1)
            {
                exits.Remove(direction);
            }

        }

        public bool CanExit(string direction)
        {
            foreach (string validExit in exits)
            {
                if (validExit == direction)
                {
                    return true;
                }
            }
            return false;
        }


        #endregion

        #region Private Methods
        
        // Private Methods

        private string GetItemList()
        {
            string subTitle = TextUtil.SubTitleFormat("Items in Room");
            string itemString = "";

            if (Items.Count >0)
            {
                //if there are items in room
                foreach (Item item in Items)
                {
                    itemString += "/n[" + item.Title + "]";                    
                }
               
            }
            else
            {
                itemString = "\n<none>";
            }

            return "\n" + subTitle + itemString;
        }

        private string GetExitList()
        {
            string subTitle = TextUtil.SubTitleFormat("Possible Directions");
            string exitString = "";

            if (exits.Count > 0)
            {
                //if there exists availble
                foreach (string exit in exits)
                {
                    exitString += "/n[" + exit + "]";
                }

            }
            else
            {
                exitString = "\n<none>";
            }

            return "\n" + subTitle + exitString;
        }

        private string GetCoordinates()
        {
            for (int y = 0; y < Level.Rooms.GetLength(1); y++)
            {
                for (int x = 0; x < Level.Rooms.GetLength(0); x++)
                {
                    if (this == Level.Rooms[x,y])
                    {
                        return "[" + x.ToString() + "," + y.ToString() + "]";
                    }
                    
                }

            }
            return "Room Outside Level Grid";
            
        }
        #endregion
    }
}
