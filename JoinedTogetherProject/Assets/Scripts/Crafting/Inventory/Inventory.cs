using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //List of all Inventory Spots
    public GameObject[] inventorySize;

   

    [SerializeField] private List<GameObject> ingredientList = new List<GameObject>();
    [SerializeField] public List<GameObject> currentInventory = new List<GameObject>();


    //..
    //Checks for which ones are taken and not taken
    //assign items to spots != taken 

    //If pointer down then activate collided items movement script
    //else turn movement off until pressed 

    private void Start()
    {
       
        inventorySize = ingredientList.ToArray();

        for (int i = 0; i < inventorySize.Length; i++)
        {
            if (inventorySize[i].activeSelf == true)
            {
                 currentInventory.Add(inventorySize[i]);
            }
        }
    }


    private void Update()
    {
        if (currentInventory.Count != 0)
        {
            for (int i = 0; i < currentInventory.Count; i++)
            {
                currentInventory[i].SetActive(true);
            }
             
        }
    }

}
