using UnityEngine;

public class InteractManager : MonoBehaviour {
    public LayerMask pickupMask;

    private UIManager uiManager;

    // Start is called before the first frame update
    void Start() {
        uiManager = UIManager.instance;
    }

    // Update is called once per frame
    void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2f)) {
            if (hit.collider.CompareTag("Pickable")) InteractWithPickable(hit);
            if (hit.collider.CompareTag("Door")) InteractWithDoor(hit);
        } else {
            uiManager.CloseInteractPrompt();
        }
    }

    public void InteractWithPickable(RaycastHit hit) {
        PickableObject pickableInfo = hit.collider.GetComponent<PickableObject>();
        uiManager.OpenInteractPrompt(pickableInfo.name, pickableInfo.interactKey);
        if (Input.GetKeyDown(KeyCode.E)) {
            print(hit.collider.name);
            InventoryManager.Instance.AddItemToInventory(pickableInfo.itemSO);
            Destroy(hit.collider.gameObject);
        }
    }

    public void InteractWithDoor(RaycastHit hit) {
        DoorEngine door = hit.collider.GetComponent<DoorEngine>();
        uiManager.OpenInteractPrompt("Door", KeyCode.E);
        if (Input.GetKeyDown(KeyCode.E)) {
            door.OpenDoor();
        }
    }
}
