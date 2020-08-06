using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventFloat : UnityEvent<float> {}

public class GameEventListenerFloat : GameEventListener
{
    public UnityEventFloat response;

    public override void OnEventRaised(float input) {
        response.Invoke(input);
    }
}
