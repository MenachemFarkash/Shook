using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour {
    public InventoryItem itemSO;
    public Image icon;
    public TextMeshProUGUI itemName;
    // Start is called before the first frame update
    void Start() {
        if (itemSO != null) {
            icon.sprite = itemSO.icon;
            itemName.text = itemSO.name;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
