using UnityEngine;

public class Knockback : MonoBehaviour
{
    public float thrust;
    public float knockTime;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("breakable")) {
            collision.GetComponent<Pot>().Destroy();
        } else if (collision.gameObject.CompareTag(Constants.TAG_ENEMY) || collision.gameObject.CompareTag(Constants.TAG_PLAYER)) {
            Rigidbody2D rbHit = collision.GetComponent<Rigidbody2D>();
            if (rbHit != null) {
                rbHit.AddForce((collision.transform.position - transform.position).normalized * thrust, ForceMode2D.Impulse);
                Enemy enemy = collision.GetComponent<Enemy>();
                if (enemy != null) {
                    enemy.Knock(knockTime, damage);
                }
                PlayerController player = collision.GetComponent<PlayerController>();
                if (player != null) {
                    player.Knock(knockTime, damage);
                }
            }
        }
    }

    

}
