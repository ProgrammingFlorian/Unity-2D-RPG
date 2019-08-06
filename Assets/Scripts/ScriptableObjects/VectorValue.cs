using UnityEngine;

[CreateAssetMenu]
public class VectorValue : ScriptableObject, ISerializationCallbackReceiver {

    public Vector2 initalValue;
    public Vector2 value;

    public void OnAfterDeserialize() {
        value = initalValue;
    }

    public void OnBeforeSerialize() {
    }

}