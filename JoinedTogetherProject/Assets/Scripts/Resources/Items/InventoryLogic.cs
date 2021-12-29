using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryLogic : MonoBehaviour
{
    public List<Item> playerItems = new List<Item>();
    ItemDatabase itemDatabase;

    private void Awake()
    {
        itemDatabase = FindObjectOfType<ItemDatabase>();
    }

    public void GiveItemID(int id)
    {
        Item itemToAdd = itemDatabase.GetItemID(id);
        playerItems.Add(itemToAdd);
    }

    public void GiveItemName(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItemTitle(itemName);
        playerItems.Add(itemToAdd);
    }

    public Item CheckForItem(int id)
    {
        return playerItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);

        if (itemToRemove != null)
        {
            playerItems.Remove(itemToRemove);
        }
    }
}
