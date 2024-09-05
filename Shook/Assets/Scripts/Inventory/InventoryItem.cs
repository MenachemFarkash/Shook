using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public class InventoryItem : ScriptableObject {
    public new string name;
    public Sprite icon;
}
