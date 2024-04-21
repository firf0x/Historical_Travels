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

    private void Awake() {
        Move move = new Move();
        Heal heal = new Heal();
        Initialize(move, heal);
    }

    private void Initialize(Move _move, Heal _heal)
    {
        //Player only
        _player.Initialize(_heal);
        
        //Move only
        _BGController.Initialize(_move);

        //Heal only
        _healBar.Initialize(_heal);
    }   
}
