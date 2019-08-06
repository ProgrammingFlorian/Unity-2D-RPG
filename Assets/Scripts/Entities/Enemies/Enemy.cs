using System.Collections;
using UnityEngine;

public enum EnemyState {
    idle,
    follow,
    attack,
    stagger
}

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    public EnemyState currentState;
    public float maxHealth;
    protected float health;
    public string enemyName;
    public LootTable lootTable;

    private RoomDungeonEnemy room;

    protected Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        health = maxHealth;
    }

    public void Heal(float amount) {
        health += amount;
        if (health > maxHealth)
            health = maxHealth;
    }

    public void Damage(float amount) {
        health -= amount;
        if (health <= 0f) {
            health = 0f;
            OnDeath();
            Die();
        }
    }

    private void OnDeath() {
        if (room != null) {
            room.EnemyDeath();
        }
        if (lootTable != null) {
            GameObject loot = lootTable.GetLoot();
            if (loot != null) {
                Instantiate(loot, transform.position, Quaternion.identity);
            }
        }
    }

    protected virtual void Die() {
        gameObject.SetActive(false);
    }

    public void Knock(float knockTime, float damage) {
        if (currentState != EnemyState.stagger) {
            Damage(damage);
            if (health > 0f) {
                currentState = EnemyState.stagger;
                StartCoroutine(KnockCo(knockTime));
            }
        }
    }

    private IEnumerator KnockCo(float knockTime) {
        yield return new WaitForSeconds(knockTime);
        rb.velocity = Vector2.zero;
        currentState = EnemyState.idle;
    }

    public void SetDungeonRoom(RoomDungeonEnemy room) {
        this.room = room;
    }

}
