using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;

    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdapter;
    public PlayerInventory pi;

    private void Start()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdapter = new InventorySystemAdapter();
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Add item (no adaptor"))
        {
            inventorySystem.AddItem(item);
        }
        if (GUILayout.Button("Add item (with adaptor"))
        {
            inventorySystemAdapter.AddItem(item, SaveLocation.Both);
        }


        if (GUILayout.Button("Save player inventory"))
        {
            inventorySystemAdapter.AddItems(pi.inventoryItems, SaveLocation.Local);
        }
        
    }
}
