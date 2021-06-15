using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySpot : MonoBehaviour
{
    public bool spotTaken;
    public GameObject spotObj = null;


    private void Start()
    {
        spotTaken = false;
    }
}
