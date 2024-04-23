using System;

public class BuffAttack
{
    public event Action<float> BuffDamage;
    
    // общий параметр урона
    private float _buffAttack = 0f;

    public void addBuff(float attackDamage)
    {
        if(attackDamage > 0)
        {
            this._buffAttack += attackDamage;
            BuffDamage?.Invoke(this._buffAttack);
        }
    }
    public float GetValue()
    {
        return this._buffAttack;
    }
}
