using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGrinch
{
    class Inventory
    {
        //Items list the player has
        List<Item> Inv = new List<Item>();


        public Inventory()
        {

        }



        public string invAdd(Item item)
        {
            if (!Inv.Contains(item))
            {




                Inv.Add(item);
                return item.getName() + " was added to your inventory";

            }
            else {
                return "";
                    };
        }

        public List<Item> invGet()
        {
            return Inv;
        }

        public bool Contains(string Name)
        {
            bool hasItem = false;
            foreach (Item element in Inv)
            {
                if (element.getName() == Name)
                {
                    hasItem = true;
                }

            }
            return hasItem;
        }

        public string RemoveItem(Item itm)
        {
            if (Contains(itm.getName()))
            {
                Inv.Remove(itm);
                return itm.getName() + " was removed from your person";
            }
            else
            {
                return "";
            }
        }
        public void RemoveAll()
        {
            this.Inv.Clear();
        }
        public Item returnItem(string Name)
        {
            Item selectedItem = null;
            foreach (Item element in Inv)
            {
                if (element.getName() == Name)
                {
                    selectedItem = element;
                    return selectedItem;
                }
                else
                    selectedItem = null;
            }
            return selectedItem;
        }
    }


}