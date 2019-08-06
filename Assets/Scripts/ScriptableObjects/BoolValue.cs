using UnityEngine;

[CreateAssetMenu]
public class BoolValue : ScriptableObject, ISerializationCallbackReceiver {
    public bool initalValue;
    public bool value;

    public void OnAfterDeserialize() {
        value = initalValue;
    }

    public void OnBeforeSerialize() {
    }
}
