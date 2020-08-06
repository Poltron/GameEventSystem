using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class GameEventListener : MonoBehaviour {
    [Tooltip("Event to register with.")]
    public GameEvent customEvent;

    void OnEnable()
    {
        if (customEvent != null)
        {
            customEvent.RegisterListener(this);
        }
        else
        {
            enabled = false;
        }
    }
    void OnDisable()
    {
        if (customEvent != null)
        {
            customEvent.UnregisterListener(this);
        }
    }
    
    public virtual void OnEventRaised() {}
    public virtual void OnEventRaised(int input) {}
    public virtual void OnEventRaised(float input) {}
    public virtual void OnEventRaised(string input) {}
    public virtual void OnEventRaised(bool input) {}
    public virtual void OnEventRaised(UnityEngine.Object input) {}
    public virtual void OnEventRaised(GameObject input) {}
    public virtual void OnEventRaised(Transform input) {}
}
