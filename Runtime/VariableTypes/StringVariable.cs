using UnityEngine;

[CreateAssetMenu(fileName = "String", menuName = "Variables/String", order = 3)]
public class StringVariable : ScriptableObject
{
    public string DefaultValue;
    private string currentValue;

    public string CurrentValue
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    private void OnEnable()
    {
        currentValue = DefaultValue;
    }
}
