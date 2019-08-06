using UnityEngine;

[CreateAssetMenu(menuName = "Attacks/Instantiate")]
public class InstantiatePrefab : Attack {

    public GameObject projectile;

    public override void Perform(Vector3 position, Vector2 direction) {
        GameObject go = Instantiate(projectile, position, Quaternion.identity);
        go.GetComponent<Projectile>().Launch(direction);
    }

}
