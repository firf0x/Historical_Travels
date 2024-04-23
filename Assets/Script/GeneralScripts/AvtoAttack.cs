using System;
using UnityEngine;

public class AvtoAttack : MonoBehaviour {
    
    [SerializeField] private float _maxTime;

    private Timer _timer;
    private BuffAttack _buff;

    private float _generalDamage;

    public void Initialize(BuffAttack buffAttack)
    {
        _buff = buffAttack;
        _timer = new Timer(_maxTime);
    }

    private void Update() {
        _timer.Recalculation(0.1);
        //Debug.Log(_timer.GetTime());
        if(_timer.GetTime() < 0.1f)
        {
            try
            {
                AvtoAttacks();
            }
            catch (NullReferenceException ex)
            {
                throw new System.Exception("На сцене пока нет противника");
            }
        }
    }

    private void AvtoAttacks()
    {
        IDomageble enemy = GameObject.FindWithTag("DefaultEnemy").GetComponent<IDomageble>();
        enemy.Damage(_buff.GetValue());
        Debug.Log($"Авто атака : {_buff.GetValue()}");
    }
}