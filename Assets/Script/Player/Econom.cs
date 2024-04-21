using System;
public class Econom
{
    public event Action<int> E_AddValueMoney;
    public event Action<int> E_DelValueMoney;
    private int _value = 0;

    public void Add(int value)
    {
        if(value < 0)
            return;
        this._value += value;
        E_AddValueMoney?.Invoke(this._value);
    }

    public void Del(int value)
    {
        if(value < 0)
            return;
        this._value -= value;
        E_DelValueMoney?.Invoke(this._value);
    }

    public int GetValue()
    {
        return _value;
    }
}