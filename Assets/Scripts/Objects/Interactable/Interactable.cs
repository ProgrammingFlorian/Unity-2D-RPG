using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class Interactable : MonoBehaviour {
    public enum ContextClueType {
        None, Player, Self
    }

    public GameObject contextClue;

    protected ContextClueType contextClueType;

    private bool showContextClue = true;
    private bool canShowContextClue = false;
    private bool playerInRange;


    protected virtual void Start() {
        Context.controls.Player.Interact.performed += _ => {
            if (playerInRange) {
                OnInteraction();
            }
        };
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) && !collision.isTrigger) {
            playerInRange = true;
            OnEnter();
            canShowContextClue = true;
            UpdateContextClue();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) && !collision.isTrigger) {
            playerInRange = false;
            OnLeave();
            canShowContextClue = false;
            UpdateContextClue();
        }
    }

    protected void ShowContextClue(bool active) {
        showContextClue = active;
        UpdateContextClue();
    }

    protected void UpdateContextClue() {
        if (contextClueType == ContextClueType.Player) {
            if (canShowContextClue && showContextClue) {
                Context.AddContext(gameObject);
            } else {
                Context.RemoveContext(gameObject);
            }
        } else if (contextClueType == ContextClueType.Self && contextClue != null) {
            contextClue.SetActive(canShowContextClue && showContextClue);
        }
    }

    protected abstract void OnInteraction();

    protected virtual void OnLeave() {
    }

    protected virtual void OnEnter() {
    }

}
