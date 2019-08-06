using UnityEngine;

public abstract class Attack : ScriptableObject {
    public abstract void Perform(Vector3 position, Vector2 direction);
}
