using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftPot : MonoBehaviour, IDropHandler
{

    public List<GameObject> cookingIngredients = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("DROPPED ON ME");


        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            //eventData.pointerDrag.GetComponent<GameObject>() += cookingPot;
        }
    }
}
