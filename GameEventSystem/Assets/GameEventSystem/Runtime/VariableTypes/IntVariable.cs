using UnityEngine;

[CreateAssetMenu(fileName = "Int", menuName = "Variables/Int", order = 1)]
public class IntVariable : ScriptableObject
{
    public int DefaultValue;
    private int currentValue;

    public int CurrentValue
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    private void OnEnable()
    {
        currentValue = DefaultValue;
    }
}
