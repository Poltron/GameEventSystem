using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventTransform : UnityEvent<Transform> {}

public class GameEventListenerTransform : GameEventListener
{
    public UnityEventTransform response;

    public override void OnEventRaised(Transform input) {
        response.Invoke(input);
    }
}
