using UnityEngine;

public class Log : ChasingEnemy
{
    private enum LogState {
        wait, moveBack, die, other

    }
    private Vector3 homePosition;

    private const float waitForHomeDelay = 3f;
    private float waitForHome;
    private LogState state;

    protected override void Start() {
        base.Start();
        homePosition = transform.position;
    }

    protected override void FixedUpdate() {
        base.FixedUpdate();
        UpdateState();
        UpdateAnim();
        Move();
    }

    protected override void UpdateState() {
        if (currentState != EnemyState.stagger && state != LogState.die) {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= chaseRadius) {
                if (distance <= attackRadius) {
                    if (currentState != EnemyState.attack) {
                        currentState = EnemyState.attack;
                    }
                } else {
                    if (currentState != EnemyState.follow) {
                        currentState = EnemyState.follow;
                    }
                }
                state = LogState.other;
            } else {
                if (state == LogState.other && currentState == EnemyState.follow) {
                    state = LogState.wait;
                    waitForHome = waitForHomeDelay;
                } else if (state == LogState.wait) {
                    waitForHome -= Time.deltaTime;
                    if (waitForHome <= 0f) {
                        state = LogState.moveBack;
                    }
                } else if (state == LogState.moveBack && Vector3.Distance(homePosition, transform.position) <= 1f) {
                    state = LogState.other;
                }
                currentState = EnemyState.idle;
            }
        }
    }

    protected override void UpdateAnim() {
        base.UpdateAnim();
        anim.SetBool(Constants.ANIM_LOG_awake, currentState != EnemyState.idle || state != LogState.other);
    }

    protected override void Move() {
        if (currentState == EnemyState.follow && state != LogState.die) {
            moveDir = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        } else if (state == LogState.moveBack) {
            moveDir = (homePosition- transform.position).normalized;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
    }

    protected override void Die() {
        anim.SetTrigger(Constants.ANIM_ENTITY_die);
        state = LogState.die;
    }

    private void Death() {
        gameObject.SetActive(false);
    }

    private void OnEnable() {
        if (homePosition != Vector3.zero) {
            transform.position = homePosition;
        }
        health = maxHealth;
        currentState = EnemyState.idle;
        state = LogState.other;
    }

}
