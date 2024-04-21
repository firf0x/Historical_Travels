using System;
using UnityEngine;
using UnityEngine.UI;

public class HealBar : MonoBehaviour {

	[Header ("Слайдер для хп")]
    [SerializeField] private Slider _value;
    private Heal _healEvent;

    public void Initialize(Heal _heal) {
        _healEvent = _heal;
        _healEvent.Changed += OnChanged;
    }


    private void OnChanged(int value)
    {
        _value.value = value;
    }
}