using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem
{
    public void AddItem(InventoryItem anItem)
    {
        Debug.Log("Added Item to the cloud");
    }

    public void RemoveItem(InventoryItem anItem)
    {
        Debug.Log("Removed Item to the cloud");
    }

    public List<InventoryItem> GetInventory()
    {
        Debug.Log("Getting items from the cloud");

        return new List<InventoryItem>();
    }
}
