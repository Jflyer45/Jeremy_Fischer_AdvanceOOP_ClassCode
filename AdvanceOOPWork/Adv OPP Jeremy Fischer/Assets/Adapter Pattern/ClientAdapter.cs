using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;

    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdapter;

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
    }
}
