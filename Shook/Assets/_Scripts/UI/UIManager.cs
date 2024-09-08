using UnityEngine;

public class UIManager : MonoBehaviour {

    #region !========Singleton==========!
    public static UIManager instance;
    private void Awake() {
        instance = this;
    }
    #endregion

    [SerializeField] private GameObject InventoryUIPanel;
    [SerializeField] private GameObject HotbarPanel;

    public RectTransform hotbarPanelRectTransform;

    public bool isAnyUIOpen = false;



    // Start is called before the first frame update
    void Start() {
        hotbarPanelRectTransform = HotbarPanel.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            OpenPanel(InventoryUIPanel);
        }

        if (InventoryUIPanel.activeSelf)
            hotbarPanelRectTransform.anchoredPosition = new Vector3(0, -216, 0);
        else hotbarPanelRectTransform.anchoredPosition = new Vector3(0, -413, 0);

    }

    public bool CheckForOpenUIs() {

        // Inventory
        if (InventoryUIPanel.activeSelf)
            return true;

        return false;
    }

    private void OpenPanel(GameObject panel) {
        panel.SetActive(!panel.activeSelf);
        isAnyUIOpen = CheckForOpenUIs();
    }
}
