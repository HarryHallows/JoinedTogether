using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItemID(int id)
    {
        return items.Find(item => item.id == id);        
    }

    public Item GetItemTitle(string title)
    {
        return items.Find(item => item.title == title);
    }

    private void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            //base materials 
            new Item(1, "Moss", "This should be facing towards civilization...",
            new Dictionary<string, int>
            {
                { "Power", 0 },
                { "Defence", 0 }
            }),
            
            new Item(2, "Rock", "Stuck between me and a hardplace",
            new Dictionary<string, int>
            {
                { "Power", 0 },
                { "Defence", 0 }
            }),

            new Item(3, "Water", "Liquid which is comprised of H2o",
            new Dictionary<string, int>
            {
                { "Power", 0 },
                { "Defence", 0 }
            }),

            new Item(4, "Fire", "hot",
            new Dictionary<string, int>
            {
                { "Power", 0 },
                { "Defence", 0 }
            }),

            //tier 1 monsters
            new Item(5, "RockyMoss", "Hard rock creature with a patch of moss",
            new Dictionary<string, int>
            {
                { "Power", 10 },
                { "Defence", 20 }
            }),

            new Item(6, "SteamMonster", "Looks like that could hurt",
            new Dictionary<string, int>
            {
                { "Power", 20 },
                { "Defence", 10 }
            }),


            new Item(7, "SwampMonster", "A monster comprised of water and moss",
            new Dictionary<string, int>
            {
                { "Power", 15 },
                { "Defence", 15 }
            })
        };
    }
}