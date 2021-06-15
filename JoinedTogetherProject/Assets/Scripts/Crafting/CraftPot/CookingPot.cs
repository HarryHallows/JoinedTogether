using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingPot : MonoBehaviour
{
    //Store Craft Spot locations
    //Store Objects being held inside of the crafting spots

    public CookingSlot[] cookingSpots;

    //if craft spot 1 and craft spot 2 == taken 
    //...
    //check for what object combination is inside of cooker
    //provide new item

    //return new item to inventory list and inventory spot != taken

    private void Start()
    {
        cookingSpots = FindObjectsOfType<CookingSlot>();
    }


    private void Update()
    {
        CookingCheck();
    }

    //Checks if spots have been filled
    private void CookingCheck()
    {
        for (int i = 0; i < cookingSpots.Length; i++)
        {
            if (cookingSpots[0].spotTaken && cookingSpots[1].spotTaken)
            {
                Debug.Log("FIND RECIPE AND MAKE IT");
            }
        }


    }
}
