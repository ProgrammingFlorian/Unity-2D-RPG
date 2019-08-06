using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifetime;
    private float timeLeft;

    private Rigidbody2D rb;
    private Animator anim;

    private void Awake() {
        timeLeft = 1f;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f) {
            Vanish();
        }
    }

    public void Launch(Vector2 direction) {
        rb.velocity = direction * speed;
    }

    public void Launch(Quaternion direction) {
        transform.rotation = direction;
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.name);
        Destroy(gameObject);
    }

    protected virtual void Vanish() {
        anim.SetTrigger(Constants.ANIM_PROJECTILE_VANISH);
    }

    private void Die() {
        Destroy(gameObject);
    }

}
