using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftPot : MonoBehaviour
{
    private Inventory inventory;

    public List<Item> cookingIngredients;


    public List<GameObject> ingredientsInPlay;
    [SerializeField] private List<GameObject> basicIngredients = new List<GameObject>();

    public GameObject spotOne, spotTwo;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        //Setup initial basic item ingredients

       //Add them to RecipiesInPlay
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
