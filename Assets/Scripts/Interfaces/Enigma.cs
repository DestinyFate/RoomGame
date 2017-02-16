﻿public abstract class Enigma<AttributeType> :
    SavedMonoBehaviour
    where AttributeType : SavedAttributes, new()
{
    public bool Solved = false;

    public AttributeType Attribute
    {
        get { return m_ as AttributeType; }
        set { m_ = value; }
    }

    void Awake()
    {
        Attribute = new AttributeType();
    }

    protected virtual void Answer(bool Correct)
    {
        Solved = Correct;

        if (Correct)
            OnSuccess();
        else
            OnFail();
    }

    /// <summary>
    /// Triggered when the enigma is succeeded.
    /// </summary>
    protected abstract void OnSuccess();

    /// <summary>
    /// Triggered when the enigma is failed.
    /// </summary>
    protected abstract void OnFail();
}
