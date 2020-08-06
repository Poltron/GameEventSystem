using UnityEngine;

[CreateAssetMenu(fileName = "Float", menuName = "Variables/Float", order = 0)]
public class FloatVariable : ScriptableObject
{
    public float DefaultValue;
    private float currentValue;

    public float CurrentValue
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    private void OnEnable()
    {
        currentValue = DefaultValue;
    }
}
