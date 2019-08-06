using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    public enum PlayerState {
        walk,
        attack,
        stagger,
        interact
    }

    [Header("Properties")]
    public float speed;
    private Vector3 moveDir;
    private Vector3 faceDir;

    [HideInInspector]
    public string entryPoint;
    [Header("References")]
    public GameObject contextClue;
    public SpriteRenderer holdingItemSprite;
    [Header("Prefabs")]
    public Projectile arrowPrefab;

    private PlayerState currentState;

    private Rigidbody2D rb;
    private Animator anim;
    private Inventory inventory;
    private PlayerStats stats;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        inventory = Context.GetInventory();
        stats = Context.GetPlayerStats();

        anim.SetFloat(Constants.ANIM_PLAYER_moveX, 0f);
        anim.SetFloat(Constants.ANIM_PLAYER_moveY, -1f);

        currentState = PlayerState.walk;

        Context.controls.Player.Movement.performed += ctx => {
            moveDir = ctx.ReadValue<Vector2>();
            if (moveDir != Vector3.zero) {
                faceDir = moveDir;
            }
        };

        Context.controls.Player.Attack.performed += _ => {
            if (currentState == PlayerState.walk && !Context.GetUiManager().UiIsOpen()) {
                StartCoroutine(Attack());
            }
        };

        Context.controls.Player.Shoot.performed += _ => {
            if (currentState == PlayerState.walk) {
                ShootArrow();
            }
        };
    }

    /*
     * Updates
     */

    private void FixedUpdate() {
        if (currentState != PlayerState.interact) {
            if (currentState == PlayerState.walk) {
                Move();
            }
            UpdateAnimator();
        }
    }

    private void Move() {
        rb.MovePosition(transform.position + moveDir * speed * Time.fixedDeltaTime);
    }

    private void UpdateAnimator() {
        if (currentState == PlayerState.walk) {
            anim.SetFloat(Constants.ANIM_PLAYER_moveX, faceDir.x);
            anim.SetFloat(Constants.ANIM_PLAYER_moveY, faceDir.y);
        }
        anim.SetBool(Constants.ANIM_PLAYER_is_moving, moveDir != Vector3.zero);
    }

    /*
     * Spawning
     */ 
    private void ShootArrow() {
        Projectile arrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
        arrow.Launch(Quaternion.Euler(faceDir));
    }

    /*
     * Health
     */

    public void Heal(int amount) {
        stats.Health += amount;
    }

    public void Hurt(int amount) {
        stats.Health -= amount;
        anim.SetTrigger(Constants.ANIM_PLAYER_hurt);
        Context.ShakeCamera(1.2f, 2f, 0.3f);
        if (stats.Health <= 0f) {
            Die();
        }
    }

    private void Die() {
        gameObject.SetActive(false);
    }

    /*
     * Public methods
     */

    public void Knock(float knockTime, int damage) {
        if (currentState != PlayerState.stagger) {
            Hurt(damage);
            currentState = PlayerState.stagger;
            StartCoroutine(KnockCo(knockTime));
        }
    }

    public void SetContextClueActive(bool active) {
        contextClue.SetActive(active);
    }

    public void StartInteracting() {
        currentState = PlayerState.interact;
    }

    public void StopInteracting() {
        if (currentState == PlayerState.interact) {
            currentState = PlayerState.walk;
        }
    }

    public void HoldItem(Sprite sprite) {
        StartInteracting();
        holdingItemSprite.sprite = sprite;
        anim.SetBool(Constants.ANIM_PLAYER_holding, true);
    }

    public void StopHolding() {
        StopInteracting();
        holdingItemSprite.sprite = null;
        anim.SetBool(Constants.ANIM_PLAYER_holding, false);
    }

    /*
     * Coroutines
     */

    private IEnumerator KnockCo(float knockTime) {
        yield return new WaitForSeconds(knockTime);
        rb.velocity = Vector2.zero;
        if (currentState == PlayerState.stagger) {
            currentState = PlayerState.walk;
        }
    }
    
    private IEnumerator Attack() {
        anim.SetTrigger(Constants.ANIM_PLAYER_attack);
        currentState = PlayerState.attack;
        yield return new WaitForSeconds(0.5f);
        if (currentState == PlayerState.attack) {
            currentState = PlayerState.walk;
        }
    }

    private void OnEnable() {
        Context.controls.Enable();
    }

    private void OnDisable() {
        Context.controls.Disable();
    }

}
