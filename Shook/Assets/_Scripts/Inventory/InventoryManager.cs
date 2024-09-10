using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    #region ========Singleton=========
    public static InventoryManager Instance;
    private void Awake() {
        Instance = this;
    }
    #endregion

    public List<InventoryItem> inventoryItems = new(10);
    public int inventorySize = 10;

    public InventoryItem currentlyHeldItem;

    public GameObject InventoryContainer;

    public List<ItemSlot> itemSlots = new();

    public void Start() {
        foreach (ItemSlot slot in InventoryContainer.GetComponentsInChildren<ItemSlot>()) {
            itemSlots.Add(slot);
        }

        UpdateUI();
    }

    public void AddItemToInventory(InventoryItem item) {
        //if (inventoryItems.Contains(item)) return;

        inventoryItems.Add(item);
        UpdateUI();
    }

    public void RemoveItemFromInventory(InventoryItem item) {
        if (!inventoryItems.Contains(item)) return;

        inventoryItems.Remove(item);
        UpdateUI();
    }

    public void UpdateUI() {

        for (int i = 0; i < inventoryItems.Count; i++) {
            if (i < itemSlots.Count) {
                itemSlots[i].itemSO = inventoryItems[i];
                itemSlots[i].UpdateItem();
            } else {
                itemSlots[i].itemSO = null;
            }
        }
    }
}
