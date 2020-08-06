using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventGameObject : UnityEvent<GameObject> {}

public class GameEventListenerGameObject : GameEventListener
{
    public UnityEventGameObject response;

    public override void OnEventRaised(GameObject input) {
        response.Invoke(input);
    }
}
