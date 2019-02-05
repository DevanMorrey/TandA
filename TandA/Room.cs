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

        }

        public void ShowTitle()
        {

        }

        public Item GetItem(string itemName)
        {
            return null;
        }

        public void AddExit(string direction)
        {

        }

        public void RemoveExit(string direction)
        {

        }

        public bool CanExit(string direction)
        {
            return false;
        }
        #endregion

        // Private Methods

        private string GetItemList()
        {
            return "";
        }

        private string GetExitList()
        {
            return "";
        }

        private string GetCoordinates()
        {
            return "";
        }

    }
}
