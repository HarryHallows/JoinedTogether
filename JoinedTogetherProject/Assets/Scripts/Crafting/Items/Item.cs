using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public enum Element {Wood, Rock, Moss, Water, Dirt};

    public Element element;

    public Sprite artwork;

    public int amount;

    public new string name;
    public string customSound;

    [HideInInspector]
    public GameObject itemObject;
}
