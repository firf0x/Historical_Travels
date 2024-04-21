using System;
using UnityEngine;

public class Heal {
    // Ивенты для вызовов своих функций
    public event Action Dead;
    public event Action<int> Changed;

    // Параметры
    private int _value;

    //Инициализация используется в ((InitializeScript.cs))
    public void Initialize(int value) => this._value = value;

    // Получение урона и проверка смерти
    public void TakeDamage(float damage)
    {
        _value -= (int)damage;
        Changed?.Invoke(_value);

        if(_value <= 0)
            Dead?.Invoke();
    }
    // Получение значения здоровья
    public int GetValue()
    {
        return _value;
    }
}