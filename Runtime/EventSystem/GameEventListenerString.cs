using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventString : UnityEvent<string> {}

public class GameEventListenerString : GameEventListener
{
    public UnityEventString response;

    public override void OnEventRaised(string input) {
        response.Invoke(input);
    }
}
