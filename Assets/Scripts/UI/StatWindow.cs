using UnityEngine;
using UnityEngine.UI;

public class StatWindow : MonoBehaviour
{
    public GameObject panel;
    public Text healthText;
    public Text manaText;
    public RectTransform healthBar;
    public RectTransform manaBar;

    private float barSizeMax;

    private void Start() {
        barSizeMax = healthBar.parent.GetComponent<RectTransform>().sizeDelta.x;

        Context.GetEventManager().onHealthChanged += (health, maxHealth) => {
            if (Context.GetUiManager().StatWindowIsActive) {
                healthBar.sizeDelta = new Vector2((health / maxHealth) * barSizeMax, healthBar.sizeDelta.y);
            }
        };

        Context.GetEventManager().onManaChanged += (mana, maxMana) => {
            if (Context.GetUiManager().StatWindowIsActive) {
                manaBar.sizeDelta = new Vector2((mana / maxMana) * barSizeMax, manaBar.sizeDelta.y);
            }
        };

        Context.controls.GUI.StatWindow.performed += _ => {
            if (Context.GetUiManager().StatWindowIsActive) {
                Hide();
            } else {
                Show();
            }
        };
    }

    public void Show() {
        if (Context.GetUiManager().CanOpenWindow()) {
            panel.SetActive(true);
            Context.GetUiManager().StatWindowIsActive = true;
            healthBar.sizeDelta = new Vector2((Context.GetPlayerStats().Health / Context.GetPlayerStats().MaxHealth) * barSizeMax, healthBar.sizeDelta.y);
            manaBar.sizeDelta = new Vector2((Context.GetPlayerStats().Mana / Context.GetPlayerStats().MaxMana) * barSizeMax, manaBar.sizeDelta.y);
        }
    }

    public void Hide() {
        panel.SetActive(false);
        Context.GetUiManager().StatWindowIsActive = false;
    }

}
