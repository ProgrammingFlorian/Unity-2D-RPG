using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChasingEnemy : Enemy
{
    public float chaseRadius;
    public float attackRadius;
    public float moveSpeed;

    protected bool moveWhileAttacking = false;
    protected Vector3 moveDir;

    protected Transform player;
    protected Animator anim;

    protected virtual void Start() {
        player = Context.GetPlayer().transform;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentState = EnemyState.idle;
    }

    protected virtual void FixedUpdate() {
        UpdateState();
        Move();
        UpdateAnim();
    }

    protected virtual void UpdateState() {
        if (currentState != EnemyState.stagger) {
            float distance = Vector3.Distance(transform.position, player.position);
            if (distance <= attackRadius) {
                currentState = EnemyState.attack;
            } else if (distance <= chaseRadius) {
                currentState = EnemyState.follow;
            } else {
                currentState = EnemyState.idle;
            }
        }
    }

    protected virtual void Move() {
        if (currentState == EnemyState.follow || (moveWhileAttacking && currentState == EnemyState.attack)) {
            moveDir = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.fixedDeltaTime);
        }
    }

    protected virtual void UpdateAnim() {
        anim.SetBool(Constants.ANIM_ENTITY_is_moving, currentState == EnemyState.follow || currentState == EnemyState.attack);
        anim.SetFloat(Constants.ANIM_ENTITY_moveX, moveDir.x);
        anim.SetFloat(Constants.ANIM_ENTITY_moveY, moveDir.y);
    }
}
