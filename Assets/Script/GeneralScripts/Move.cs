using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : IMovable
{
    // Ивенты для вызовов своих функций
    public event Action<float> moveObject;
    public event Action<string> MoveInfo;

    // Локальные параметры
    private float _speedNum;
    private float _resultNum = 0f;
    
    //Инициализация используется в ((InitializeScript.cs))
    public void Initialize(float speed)
    {
        this._speedNum = speed;
    }

    //Вызывается как движение объекта в одну сторону
    public void Moved()
    {
        _resultNum += _speedNum * Time.deltaTime;
        moveObject?.Invoke(_resultNum);
    }
    //Локальная откладка
    public void Info() => MoveInfo?.Invoke($"задник идёт");
}
