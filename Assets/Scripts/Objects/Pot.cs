using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class Pot : MonoBehaviour
{
    private Animator anim;
    private Collider2D col;

    private void Start() {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
    }

    public void Destroy() {
        anim.SetTrigger("destroy");
        col.enabled = false;
    }

    private void Delete() {
        gameObject.SetActive(false);
    }

    private void OnEnable() {
        if (col != null) {
            col.enabled = true;
        }
    }

}
