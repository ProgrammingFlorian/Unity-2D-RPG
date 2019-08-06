using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject window;

    private void Start() {
        Context.controls.GUI.PauseMenu.performed += _ => {
            ToggleWindow();
        };
    }

    public bool ToggleWindow() {
        if (Context.GetUiManager().pauseMenuIsActive) {
            Hide();
        } else {
            Show();
        }
        return Context.GetUiManager().pauseMenuIsActive;
    }

    public void Show() {
        window.SetActive(true);
        Time.timeScale = 0f;
        Context.GetUiManager().pauseMenuIsActive = true;
    }

    public void Hide() {
        window.SetActive(false);
        Time.timeScale = 1f;
        Context.GetUiManager().pauseMenuIsActive = false;
    }

}
