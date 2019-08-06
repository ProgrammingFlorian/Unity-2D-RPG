using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static bool exists = false;

    private void Awake() {
        if (exists) {
            DestroyImmediate(gameObject);
        } else {
            exists = true;
            DontDestroyOnLoad(gameObject);
        }
    }
}
