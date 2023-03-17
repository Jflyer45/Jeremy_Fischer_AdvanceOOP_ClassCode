using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystemAdapter : InventorySystem, IInventorySystem
{
    private List<InventoryItem> cloudInventory;

    public void SyncInventories()
    {
        var cloudInventory = GetInventory();
        Debug.Log("Downloaded the cloud inventory");
    }

    public void AddItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if(aLocation == SaveLocation.Cloud)
        {
            AddItem(anItem);
        }
        else if (aLocation == SaveLocation.Local)
        {
            Debug.Log("Have code here to save to a local drive");
        }
        else
        {
            AddItem(anItem);
            Debug.Log("Have code here to save to a local drive");
        }
    }
    public void RemoveItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            RemoveItem(anItem);
        }
        else if (aLocation == SaveLocation.Local)
        {
            Debug.Log("Have code here to remove to a local drive");
        }
        else
        {
            RemoveItem(anItem);
            Debug.Log("Have code here to remove to a local drive");
        }
    }

    public List<InventoryItem> GetInventory(SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
             GetInventory();
        }
        else if (aLocation == SaveLocation.Local)
        {
            Debug.Log("Return the local inventory stuff");
        }
        else
        {
            return GetInventory();
            Debug.Log("This is were you would sync");
        }
        return new List<InventoryItem>();
    }
    
}
