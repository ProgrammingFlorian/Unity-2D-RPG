using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class LogPatrol : Enemy {

    private Transform player;
    public float chaseRadius;
    public float attackRadius;
    public float moveSpeed;

    public Transform[] patrolPositons;
    public bool backForthPatrol;
    private int currentPosition = 0;
    private Vector3 moveDir;

    private Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
        player = Context.GetPlayer().transform;
        currentState = EnemyState.idle;
        anim.SetBool(Constants.ANIM_LOG_awake, true);
        anim.SetBool(Constants.ANIM_ENTITY_is_moving, true);
    }

    private void FixedUpdate() {
        UpdateState();
        UpdateAnim();
        Move();
    }

    private void UpdateState() {
        if (currentState != EnemyState.stagger) {
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
            } else {
                if (Vector3.Distance(transform.position, patrolPositons[currentPosition].position) < 0.5f) {
                    currentPosition++;
                    if (currentPosition == patrolPositons.Length) {
                        if (backForthPatrol) {
                            for (int i = 0; i < patrolPositons.Length / 2; i++) {
                                Transform t = patrolPositons[i];
                                patrolPositons[i] = patrolPositons[patrolPositons.Length - i - 1];
                                patrolPositons[patrolPositons.Length - i - 1] = t;
                            }
                            currentPosition = 1;
                        } else {
                            currentPosition = 0;
                        }
                    }
                } else if (currentState == EnemyState.follow || currentState == EnemyState.attack) {
                    currentState = EnemyState.idle;
                }
            }
        }
    }

    private void UpdateAnim() {
        anim.SetFloat(Constants.ANIM_ENTITY_moveX, moveDir.x);
        anim.SetFloat(Constants.ANIM_ENTITY_moveY, moveDir.y);
    }

    private void Move() {
        if (currentState == EnemyState.follow) {
            moveDir = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.fixedDeltaTime);
        } else if (currentState == EnemyState.idle) {
            moveDir = (patrolPositons[currentPosition].position - transform.position).normalized;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.fixedDeltaTime);
        }
    }

    protected override void Die() {
        anim.SetTrigger(Constants.ANIM_ENTITY_die);
    }

    private void Death() {
        gameObject.SetActive(false);
    }

    private void OnEnable() {
        transform.position = patrolPositons[0].position;
        currentPosition = 0;
        health = maxHealth;
        currentState = EnemyState.idle;
    }

}
