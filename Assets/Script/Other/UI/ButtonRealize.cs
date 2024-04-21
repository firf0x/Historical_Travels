using System;
using UnityEngine;
using UnityEngine.UI;
using Assets.Resources.Config.Solders;

public class ButtonRealize : MonoBehaviour {
    
    // Класс с доп.функционалом
    private BuffAttack _bAttack;
    
    private Econom _eco;

    // Параметры
    private float _time;
    private float _buffDamage = 0;

    [SerializeField] private bool _isActive = false;

    // Скрытые компоненты юнити
    private Button _button;

    // Инициализация
    public void Initialize(BuffAttack bAttack, Econom eco)
    {
        this._eco = eco;
        this._bAttack = bAttack;
        _button = gameObject.GetComponent<Button>();
        _button.onClick.AddListener(buttonTap);
        
        var allCellInfos = Resources.LoadAll<CellSolder>("");

        foreach (var CellSolder in allCellInfos)
        {
            Debug.Log(CellSolder.Id);
        }

    }

    private void buttonTap()
    {
        if(_isActive != false)
        {
            _bAttack.addBuff(_buffDamage);

        }
    }


    private void FixedUpdate() {
        if(_eco.GetValue() >= 0)
        {

        } 
    }
}