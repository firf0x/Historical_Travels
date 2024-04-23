using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeScript : MonoBehaviour
{

	[Header ("Скрипт на показ хп")]
    [SerializeField] private HealBar _healBar;
	[Header ("Скрипт на передвижение сцены")]
    [SerializeField] private BackGroundController _BGController;
	[Header ("Скрипт игрока")]
    [SerializeField] private Player _player;
	[Header ("Скрипт реализации кнопок")]
    [SerializeField] private List<ButtonRealize> _bRealize = new List<ButtonRealize>{};
	[Header ("Скрипт на Авто-Атаку")]
    [SerializeField] private AvtoAttack _avtoAttack;

    private void Awake() {
        Move move = new Move();
        Heal heal = new Heal();
        BuffAttack bAttack = new BuffAttack();
        Econom eco = new Econom();

        Initialize(move, heal, bAttack, eco);
    }

    private void Initialize(Move _move, Heal _heal, BuffAttack _bAttack, Econom _eco)
    {
        //Player only
        _player.Initialize(_heal);
        
        //Move only
        _BGController.Initialize(_move);

        //Heal only
        _healBar.Initialize(_heal);

        //Button only
        for (int i = 0; i < _bRealize.Count; i++)
        {
            _bRealize[i].Initialize(_bAttack, _eco);            
        }

        //
        _avtoAttack.Initialize(_bAttack);
    }   
}
