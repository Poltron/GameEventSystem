using System;
using UnityEngine;

[System.Serializable]
public class FloatReadOnlyReference
{
    public bool useConstant = true;
    public float constantValue;
    public FloatVariable variable;

    public float value {
        get {
            return useConstant ? constantValue : variable.CurrentValue;
        }
    }
}

[System.Serializable]
public class FloatReference
{
    public bool useConstant = true;
    public float constantValue;
    public FloatVariable variable;

    public float value
    {
        get
        {
            return useConstant ? constantValue : variable.CurrentValue;
        }
        set
        {
            if (!useConstant)
                variable.CurrentValue = value;
            else
            {
                Debug.LogWarning("Setting constant value in FloatReference");
                constantValue = value;
            }
        }
    }
}

[System.Serializable]
public class IntReadOnlyReference
{
    public bool useConstant = true;
    public int constantValue;
    public IntVariable variable;

    public int value {
        get {
            return useConstant ? constantValue : variable.CurrentValue;
        }
    }
}

[System.Serializable]
public class IntReference
{
    public bool useConstant = true;
    public int constantValue;
    public IntVariable variable;

    public int value
    {
        get
        {
            return useConstant ? constantValue : variable.CurrentValue;
        }
        set
        {
            if (!useConstant)
                variable.CurrentValue = value;
            else
            {
                Debug.LogWarning("Setting constant value in IntReference");
                constantValue = value;
            }
        }
    }
}

[System.Serializable]
public class BoolReadOnlyReference
{
    public bool useConstant = true;
    public bool constantValue;
    public BoolVariable variable;

    public bool value {
        get {
            return useConstant ? constantValue : variable.CurrentValue;
        }
    }
}

[System.Serializable]
public class BoolReference
{
    public bool useConstant = true;
    public bool constantValue;
    public BoolVariable variable;

    public bool value
    {
        get
        {
            return useConstant ? constantValue : variable.CurrentValue;
        }
        set
        {
            if (!useConstant)
                variable.CurrentValue = value;
            else
            {
                Debug.LogWarning("Setting constant value in BoolReference");
                constantValue = value;
            }
        }
    }
}

[System.Serializable]
public class StringReadOnlyReference
{
    public bool useConstant = true;
    public string constantValue;
    public StringVariable variable;

    public string value {
        get {
            return useConstant ? constantValue : variable.CurrentValue;
        }
    }
}

[System.Serializable]
public class StringReference
{
    public bool useConstant = true;
    public string constantValue;
    public StringVariable variable;

    public string value
    {
        get
        {
            return useConstant ? constantValue : variable.CurrentValue;
        }
        set
        {
            if (!useConstant)
                variable.CurrentValue = value;
            else
            {
                Debug.LogWarning("Setting constant value in StringReference");
                constantValue = value;
            }
        }
    }
}