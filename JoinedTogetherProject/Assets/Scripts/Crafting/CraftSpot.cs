using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftSpot : MonoBehaviour, IDropHandler
{
    private GameObject tempIngredient;
    private CraftPot craftPot;

    // Start is called before the first frame update
    void Start()
    {
        craftPot = GetComponent<CraftPot>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + GetComponent<RectTransform>().anchoredPosition);
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            tempIngredient = eventData.pointerDrag;

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition / gameObject.GetComponentInParent<Canvas>().scaleFactor;

            if (eventData.pointerDrag.CompareTag("BasicIngredient"))
            {
                Debug.Log("Simple ingredient placed in pot");
                craftPot.ingredientsInPlay.Add(tempIngredient);
            }
           
        }
    }
}
