using UnityEngine;

[CreateAssetMenu(fileName = "Bool", menuName = "Variables/Bool", order = 2)]
public class BoolVariable : ScriptableObject
{
    public bool DefaultValue;
    private bool currentValue;

    public bool CurrentValue
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    private void OnEnable()
    {
        currentValue = DefaultValue;
        Debug.Log("useless line");
        Debug.Log("useless line2");
        Debug.Log("useless line3");
    }
}
