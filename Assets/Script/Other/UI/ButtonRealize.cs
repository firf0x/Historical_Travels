using System;
using UnityEngine;
using UnityEngine.UI;
using Assets.Resources.Config;

public class ButtonRealize : MonoBehaviour {

    //----------------------------------------------------------------------------    
    // Класс с доп.функционалом
    private BuffAttack _bAttack;
    
    private Econom _eco;

    //----------------------------------------------------------------------------
    // Параметры

    public CellSolder ocalInfo;
    private float _time;
    [SerializeField] private bool _isActive = false;

    //----------------------------------------------------------------------------

    // Скрытые компоненты юнити
    private Button _button;

    // Инициализация
    public void Initialize(BuffAttack bAttack, Econom eco)
    {
        this._eco = eco;
        this._bAttack = bAttack;
        _button = gameObject.GetComponent<Button>();
        _button.onClick.AddListener(buttonTap);
    }

    private void buttonTap()
    {
        if(_isActive != false)
        {
            _bAttack.addBuff(this.ocalInfo.AttackDamage);
            Debug.Log($"autoDamage {_bAttack.GetValue()}");
        }   
    }


    private void FixedUpdate() {
        if(this._eco.GetValue() >= this.ocalInfo.Cost)
        {
            _isActive = true;
        }
    }
} 