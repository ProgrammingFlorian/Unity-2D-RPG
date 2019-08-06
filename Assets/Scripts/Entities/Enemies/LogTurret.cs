using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LogTurret : Enemy
{
    public GameObject projectile;

    public float range;
    public float fireDelay;
    private float nextFire;
    private bool canFire = false;

    private Transform player;
    private Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
        player = Context.GetPlayer().transform;
        currentState = EnemyState.idle;
        anim.SetBool(Constants.ANIM_LOG_awake, true);
        anim.SetBool(Constants.ANIM_ENTITY_is_moving, false);
    }

    private void Update() {
        UpdateDirection();
        CheckFire();
        UpdateFire();
    }

    private void UpdateDirection() {
        Vector2 direction = (player.position - transform.position).normalized;
        anim.SetFloat(Constants.ANIM_ENTITY_moveX, direction.x);
        anim.SetFloat(Constants.ANIM_ENTITY_moveY, direction.y);
    }

    private void UpdateFire() {
        if (canFire) {
            nextFire -= Time.deltaTime;
            if (nextFire <= 0f) {
                nextFire = fireDelay;
                spawnProjectile();
            }
        }
    }

    private void CheckFire() {
        canFire = Vector3.Distance(transform.position, player.position) <= range;
    }

    private void spawnProjectile() {
        GameObject projectileGO = Instantiate(projectile, transform.position, Quaternion.identity);
        Projectile projectileScript = projectileGO.GetComponent<Projectile>();
        if (projectileScript != null) {
            projectileScript.Launch((player.position - transform.position).normalized);
        }
    }

    protected override void Die() {
        anim.SetTrigger(Constants.ANIM_ENTITY_die);
    }

    private void Death() {
        gameObject.SetActive(false);
    }

    private void OnEnable() {
        health = maxHealth;
        currentState = EnemyState.idle;
    }
}
