using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DoorSwitch : MonoBehaviour
{
    [Header("Door")]
    public SpriteRenderer doorRenderer;
    public Collider2D doorCollider;
    [Header("Switch")]
    public Sprite pressedSprite;
    public Sprite releasedSprite;
    [Header("Timed Switch - 0s = forever")]
    public float timeDelay;
    private float timeLeft;

    private SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        if (timeLeft > 0f && timeDelay != 0f) {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0f) {
                SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) & !collision.isTrigger) {
            SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) & !collision.isTrigger) {
            if (timeDelay != 0f) {
                timeLeft = timeDelay;
            }
        }
    }

    private void SetActive(bool active) {
        spriteRenderer.sprite = active ? pressedSprite : releasedSprite;
        doorRenderer.enabled = !active;
        doorCollider.enabled = !active;
    }

}
