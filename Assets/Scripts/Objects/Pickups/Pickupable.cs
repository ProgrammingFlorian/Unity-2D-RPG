using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class Pickupable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag(Constants.TAG_PLAYER) && !collision.isTrigger) {
            OnPickup();
            Destroy(gameObject);
        }
    }

    protected abstract void OnPickup();

}
