using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventInt : UnityEvent<int> {}

public class GameEventListenerInt : GameEventListener
{
    public UnityEventInt response;

    public override void OnEventRaised(int input) {
        response.Invoke(input);
    }
}
