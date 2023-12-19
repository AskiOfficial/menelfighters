using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        //Linijka na dodanie itemu do listy:
        AddItem(new Item { itemType = Item.ItemType.Chleb, amount = 1 });
    }

    public void AddItem(Item item)
    {
        //Funkcja na dodanie itemu
        itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
