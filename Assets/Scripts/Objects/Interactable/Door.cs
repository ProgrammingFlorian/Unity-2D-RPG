using UnityEngine;

public class Door : Interactable
{
    public enum DoorType {
        key, enemy, button
    }

    public DoorType type;
    public bool open = false;
    public BoxCollider2D col;
    public SpriteRenderer sprite;

    //If it's an enemy room door, push the player if he collides for the first time
    private bool enemyFirst = true;

    private Door() {
        if (type == DoorType.enemy) {
            contextClueType = ContextClueType.None;
        } else {
            contextClueType = ContextClueType.Self;
        }
    }

    protected override void Start() {
        base.Start();
        SetActive(open);
    }

    protected override void OnInteraction() {
        if (type == DoorType.key) {
            if (Context.GetInventory().HasAnyKey()) {
                Open();
            }
        }
    }

    /*
     * Opens (true)/Closes (false) the door
     */
    private void SetActive(bool active) {
        ShowContextClue(!active);
        open = active;
        sprite.enabled = !active;
        col.enabled = !active;
    }

    public void Open() {
        SetActive(true);
    }

    public void Close() {
        enemyFirst = true;
        SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (type == DoorType.enemy && enemyFirst && collision.collider.CompareTag(Constants.TAG_PLAYER)) {
            collision.transform.position += transform.position - collision.transform.position;
            enemyFirst = false;
        }
    }

}
