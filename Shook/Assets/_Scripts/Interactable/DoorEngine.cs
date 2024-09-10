using UnityEngine;

public class DoorEngine : MonoBehaviour {
    private bool isOpen = false;
    public void OpenDoor() {
        if (isOpen) {
            transform.Rotate(0, -90, 0);
            isOpen = false;
            return;
        }
        transform.Rotate(0, 90, 0);
        isOpen = true;
    }
}
