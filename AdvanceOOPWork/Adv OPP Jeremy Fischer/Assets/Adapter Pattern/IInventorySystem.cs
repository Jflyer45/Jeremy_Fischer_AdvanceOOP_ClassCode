using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This tells us how we wished the original class worked
// 
public interface IInventorySystem
{
    void SyncInventories();

    void AddItem(InventoryItem anItem, SaveLocation aLocation);

    void AddItems(List<InventoryItem> anItems, SaveLocation aLocation);
    void RemoveItem(InventoryItem anItem, SaveLocation aLocation);
    List<InventoryItem> GetInventory(SaveLocation aLocation);


}
