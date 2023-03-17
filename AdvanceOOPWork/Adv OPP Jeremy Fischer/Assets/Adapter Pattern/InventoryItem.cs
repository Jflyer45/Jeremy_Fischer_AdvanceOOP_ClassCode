using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new item", menuName = "Inventory")]
public class InventoryItem : ScriptableObject
{
    public string itemName;
    public int wieght;
    public int value;
}
