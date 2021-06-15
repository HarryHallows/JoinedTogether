using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CookingSlot : MonoBehaviour, IDropHandler
{

    public bool spotTaken;
    [SerializeField] private RectTransform objectPosition;
    [SerializeField] private RectTransform spotPosition;


    // Start is called before the first frame update
    void Start()
    {
        spotPosition = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        objectPosition = eventData.pointerDrag.GetComponent<RectTransform>();

        objectPosition.anchoredPosition = new Vector2(spotPosition.anchoredPosition.x, spotPosition.anchoredPosition.y);
        Debug.Log(objectPosition.anchoredPosition = new Vector2(spotPosition.anchoredPosition.x, spotPosition.anchoredPosition.y));

        if (objectPosition.anchoredPosition == spotPosition.anchoredPosition)
        {
            spotTaken = true;
        }
    }


}
