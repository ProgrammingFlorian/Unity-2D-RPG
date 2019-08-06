using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    public string entryPointName;

    void Start()
    {
        if (Context.GetPlayer().entryPoint == entryPointName) {
            Context.GetPlayer().transform.position = transform.position;
            Context.GetUiManager().FadeOut();
        }
    }
}
