using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Signal")]
public class Signal : ScriptableObject
{
    public List<SignalListener> listeners = new List<SignalListener>();

    public void Raise() {
        for (int i = 0; i < listeners.Count; i++) {
            listeners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(SignalListener listener) {
        listeners.Add(listener);
    }

    public void DeregisterListener(SignalListener listener) {
        listeners.Remove(listener);
    }

}
