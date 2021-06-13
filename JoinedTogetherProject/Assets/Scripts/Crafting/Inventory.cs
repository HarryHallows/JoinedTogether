using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

       
        AddItem(new Item { element = Item.Element.Rock, amount = 1 });

        Debug.Log("Inventory" + itemList.Count);

    }

    public void AddItem(Item item)
    {
        itemList.Add(item);

        Debug.Log(itemList);
    }
}
