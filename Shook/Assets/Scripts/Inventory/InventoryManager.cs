using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public List<InventoryItem> inventoryItems = new(10);
    public int inventorySize = 10;

    public InventoryItem currentlyHeldItem;

    public GameObject InventoryContainer;


    void Start() {

    }

    void Update() {

    }

    public void AddItemToInventory(InventoryItem item) {
        if (inventoryItems.Contains(item)) return;

        inventoryItems.Add(item);
    }

    public void RemoveItemFromInventory(InventoryItem item) {
        if (!inventoryItems.Contains(item)) return;

        inventoryItems.Remove(item);
    }

    public void UpdateUI() {

    }
}
