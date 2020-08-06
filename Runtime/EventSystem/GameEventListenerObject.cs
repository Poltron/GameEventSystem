using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventObject : UnityEvent<Object> {}

public class GameEventListenerObject : GameEventListener
{
    public UnityEventObject response;

    public override void OnEventRaised(Object input) {
        response.Invoke(input);
    }
}
