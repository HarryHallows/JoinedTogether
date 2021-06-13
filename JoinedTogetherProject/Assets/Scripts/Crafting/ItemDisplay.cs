using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] private Item item;

    // Start is called before the first frame update
    void Start()
    {
        item.name = item.element.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
