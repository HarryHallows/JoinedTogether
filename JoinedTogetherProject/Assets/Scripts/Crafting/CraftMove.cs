using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftMove : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler,IEndDragHandler
{

    private Inventory inventory;

    //[HideInInspector]
    private InventorySpot[] inventoryAmount;

    public List<InventorySpot> inventorySpots;
    public InventorySpot nearestSpot = null;

    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;

    private RectTransform objectPosition;

    [SerializeField] private float moveSpeed;

    private float distance;
    private float dist = Mathf.Infinity;

    private bool spotPositionFound = false;


    private void Awake()
    {
        objectPosition = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    // Start is called before the first frame update
    void Start()
    {
        inventorySpots = new List<InventorySpot>();
        inventory = GameObject.FindObjectOfType<Inventory>();
        inventoryAmount = GameObject.FindObjectsOfType<InventorySpot>();

        foreach (InventorySpot amountOfSpots in inventoryAmount)
        {
            inventorySpots.Add(amountOfSpots);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (nearestSpot == null)
        {
            Debug.Log("Looking for obj");

            if (inventorySpots.Count >= 0)
            {
                FindSpot();
            }
        }
        else
        {
            if (spotPositionFound != true)
            {
                GoToSpot();
            }
            
        }

        /*if (nearestSpot != null && nearestSpot.spotTaken != true && nearestSpot.spotObj.name == gameObject.name)*/

    }


    private void FindSpot()
    {
        foreach (InventorySpot currentSpot in inventorySpots)
        {
            distance = Vector3.Distance(GetComponent<RectTransform>().anchoredPosition, currentSpot.GetComponent<RectTransform>().anchoredPosition);
            Debug.Log(distance + " " + gameObject.name);

            if (distance < dist && !currentSpot.spotTaken)
            {
                nearestSpot = currentSpot;
                Debug.Log("Setting nearest spot" + nearestSpot.gameObject.name);
                currentSpot.spotObj = gameObject;
                inventorySpots.RemoveAt(0);
                dist = distance;
            }
            else 
            {
                return;
            }

        }
    }

    public void GoToSpot()
    {
        RectTransform ingredientPosition = GetComponent<RectTransform>();

        if (nearestSpot.spotTaken == false )
        {
            if (nearestSpot.spotObj.name == gameObject.name)
            {
                nearestSpot.spotTaken = true;
            }
            else
            {
                Debug.Log("Resetting Target");
                
                nearestSpot = null;
                dist = Mathf.Infinity;
            }
        }
        else
        {
            if (ingredientPosition.anchoredPosition != nearestSpot.gameObject.GetComponent<RectTransform>().anchoredPosition && nearestSpot.spotObj.name == gameObject.name)
            {
                ingredientPosition.anchoredPosition = Vector2.MoveTowards(ingredientPosition.anchoredPosition, nearestSpot.GetComponent<RectTransform>().anchoredPosition, moveSpeed * Time.deltaTime); //movetowards the nearest spot
            }
            else
            {
                spotPositionFound = true;
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("Dragging " + gameObject.name);

        objectPosition.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Finished Dragging");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

}
