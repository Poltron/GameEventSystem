using UnityEngine;
using UnityEngine.Events;

public class GameEventListenerVoid : GameEventListener
{
    public UnityEvent response;

    public override void OnEventRaised() {
        response.Invoke();
    }
}
