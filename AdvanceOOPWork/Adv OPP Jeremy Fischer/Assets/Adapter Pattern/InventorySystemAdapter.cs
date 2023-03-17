using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.ComponentModel;

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
            SaveToJSON(anItem);
        }
        else
        {
            AddItem(anItem);
            Debug.Log("Have code here to save to a local drive");
            SaveToJSON(anItem);
        }
    }

    public void AddItems(List<InventoryItem> anItems, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            foreach(InventoryItem i in anItems)
            {
                AddItem(i);
            }
        }
        else if (aLocation == SaveLocation.Local)
        {
            SaveMultipleToJSON(anItems);
        }
        else
        {
            foreach (InventoryItem i in anItems)
            {
                AddItem(i);
            }
            SaveMultipleToJSON(anItems);
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
    
    
    public void SaveToJSON(object obj)
    {
        string json = JsonConvert.SerializeObject(obj);

        //write string to file
        System.IO.File.WriteAllText("text.json", json);
    }
    public void SaveMultipleToJSON(List<InventoryItem> objs)
    {
        string json = "";

        foreach (object obj in objs)
        {
            json += JsonConvert.SerializeObject(obj);
        }
        //write string to file
        System.IO.File.WriteAllText("text.json", json);
    }

}
