using TMPro;
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
    [SerializeField] private GameObject InteractPrompt;



    public bool isAnyUIOpen = false;



    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            OpenPanel(InventoryUIPanel);
        }


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

    public void OpenInteractPrompt(string name, KeyCode keyCode) {
        InteractPrompt.SetActive(true);
        TextMeshProUGUI[] prompts = InteractPrompt.GetComponentsInChildren<TextMeshProUGUI>();
        prompts[0].text = name;
        prompts[1].text = keyCode.ToString();
    }

    public void CloseInteractPrompt() {
        InteractPrompt.SetActive(false);
    }
}
