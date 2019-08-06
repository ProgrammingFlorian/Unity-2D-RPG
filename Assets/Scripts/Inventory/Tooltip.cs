using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    private Item item;
    private string data;
    public GameObject tooltip;
    public Text tooltipText;

    private void Start() {
        tooltip.SetActive(false);
    }

    private void Update() {
        if (tooltip.activeSelf) {
            tooltip.transform.position = Input.mousePosition;
        }
    }

    public void Activate(Item item) {
        this.item = item;
        tooltipText.text = ConstructDataString();
        tooltip.SetActive(true);
    }

    public void Deactivate() {
        tooltip.SetActive(false);
    }

    private string ConstructDataString() {
        return "<color=#12aa2e><b>" + item.name + "</b></color>\n\n"
            + item.description + "\n\n";
    }

}
