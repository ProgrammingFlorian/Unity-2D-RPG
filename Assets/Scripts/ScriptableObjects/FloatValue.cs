using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver
{
    public float initalValue;
    public float value;

    public void OnAfterDeserialize() {
        value = initalValue;
    }

    public void OnBeforeSerialize() {}
}
