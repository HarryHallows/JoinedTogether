using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(ItemDatabase))]
public class RecipeDatabase : MonoBehaviour
{
    public List<CraftRecipe> recipes = new List<CraftRecipe>();
    private ItemDatabase itemDatabase;

    private void Awake()
    {
        itemDatabase = GetComponent<ItemDatabase>();
        BuildCraftRecipeDataBase();
    }

    public Item CheckRecipe(int[] recipe)
    {
        foreach (CraftRecipe craftRecipe in recipes)
        {
            if (craftRecipe.requiredItems.SequenceEqual(recipe))
            {
                return itemDatabase.GetItemID(craftRecipe.itemToCraft);
            }
        }

        return null;
    }

    private void BuildCraftRecipeDataBase()
    {
        recipes = new List<CraftRecipe>()
        {
            new CraftRecipe(5, 
            //rock monster recipe 
            new int[]
            {
                1,2
            })
        };
    }   
}
