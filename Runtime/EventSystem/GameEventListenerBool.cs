using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventBool : UnityEvent<bool> {}

public class GameEventListenerBool : GameEventListener
{
    public UnityEventBool response;

    public override void OnEventRaised(bool input) {
        response.Invoke(input);
    }
}
