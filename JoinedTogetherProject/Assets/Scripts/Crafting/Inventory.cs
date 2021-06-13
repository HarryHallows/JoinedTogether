using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
    public List<Item> startItems;

   
    private void Start()
    {
        foreach (Item item in startItems)
        {
            AddItem(item, true);
        }
    }

    public void AddItem(Item item, bool startItem)
    {
        items.Add(item);

        GameObject itemObj = Instantiate(itemPrefab, itemPool);
        ItemDisplay display = itemObj.GetComponent<ItemDisplay>();

        if (display != null)
            display.Setup(item);

        Debug.Log(items);
    }
}
