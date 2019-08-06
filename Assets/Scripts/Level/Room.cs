using Cinemachine;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject virtualCamera;
    public string roomName;
    public GameObject[] activateOnEnter;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) && !collision.isTrigger) {
            virtualCamera.SetActive(true);
            Context.SetVirtualCamera(virtualCamera.GetComponent<CinemachineVirtualCamera>());
            OnPlayerEnter();
        }
    }

    protected virtual void OnPlayerEnter() {
        if (roomName != "") {
            Context.GetUiManager().ShowRoomName(roomName);
        }
        ActivateComponents(true);
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) && !collision.isTrigger) {
            virtualCamera.SetActive(false);
            OnPlayerExit();
        }
    }

    protected virtual void OnPlayerExit() {
        ActivateComponents(false);
    }

    protected virtual void ActivateComponents(bool active) {
        foreach (var c in activateOnEnter) {
            c.gameObject.SetActive(active);
        }
    }
}
