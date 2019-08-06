using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Animator fadePanel;

    public GameObject uiBackground;

    public GameObject dialogueBox;
    public Text dialogueText;

    public RectTransform healthBar;
    public RectTransform manaBar;
    public float maxBarWidth;

    public Text roomName;
    public GameObject roomNameObj;
    public float roomNameDelay;
    public float roomNameWait;

    private bool inventoryIsActive;
    public bool InventoryIsActive {
        get {
            return inventoryIsActive;
        }
        set {
            inventoryIsActive = value;
            UpdateBackground();
        }
    }
    private bool statWindowIsActive;
    public bool StatWindowIsActive {
        get {
            return statWindowIsActive;
        }
        set {
            statWindowIsActive = value;
            UpdateBackground();
        }
    }
    public bool dialogueIsActive = false;
    public bool questOfferIsActive = false;
    public bool questWindowIsActive = false;
    public bool pauseMenuIsActive = false;

    private void Awake() {
        if (fadePanel == null || roomName == null || roomNameObj == null) {
            Debug.LogError("UIManager not set up");
            this.enabled = false;
        }
    }

    private void Start() {
        InitBars();
    }

    private void InitBars() {
        Context.GetEventManager().onHealthChanged += (health, maxHealth) => {
            healthBar.sizeDelta = new Vector2(((float) health / (float) maxHealth) * maxBarWidth, healthBar.sizeDelta.y);
        };
        Context.GetEventManager().onManaChanged += (mana, maxMana) => {
            manaBar.sizeDelta = new Vector2(((float) mana / (float) maxMana) * maxBarWidth, healthBar.sizeDelta.y);
        };
    }

    private void Update() {
        if (roomNameWait > 0f) {
            roomNameWait -= Time.deltaTime;
            if (roomNameWait <= 0f) {
                HideRoomName();
            }
        }
    }

    #region Fade
    public void FadeIn() {
        fadePanel.SetTrigger("fadeIn");
    }

    public void FadeOut() {
        fadePanel.SetTrigger("fadeOut");
    }
    #endregion

    #region Room Name
    public void ShowRoomName(string name) {
        roomName.text = name;
        roomNameObj.SetActive(true);
        roomNameWait = roomNameDelay;
    }

    private void HideRoomName() {
        roomNameObj.SetActive(false);
    }
    #endregion

    #region Window Managment
    public bool CanShowDialogue() {
        return !pauseMenuIsActive;
    }

    public bool CanOpenWindow() {
        return !pauseMenuIsActive && !questOfferIsActive;
    }

    public bool CanStartDrag() {
        return InventoryIsActive || StatWindowIsActive;
    }

    public bool UiIsOpen() {
        return pauseMenuIsActive || questOfferIsActive || InventoryIsActive || StatWindowIsActive || questWindowIsActive;
    }

    public void ShowDialogue() {
        dialogueIsActive = true;
        if (inventoryIsActive) {
            inventoryIsActive = false;
            Context.GetInventory().Hide();
        }
        if (questWindowIsActive) {
            questWindowIsActive = false;
            Context.GetQuestManager().Hide();
        }
        Context.GetInventory().HideBar();
    }

    public void StopDialogue() {
        dialogueIsActive = false;
        Context.GetInventory().ShowBar();
    }

    public void UpdateBackground() {
        if (InventoryIsActive || StatWindowIsActive || questWindowIsActive || questOfferIsActive) {
            uiBackground.SetActive(true);
        } else {
            uiBackground.SetActive(false);
        }
    }
    #endregion

}
