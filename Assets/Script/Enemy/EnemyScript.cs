using UnityEngine;

public class EnemyScript : MonoBehaviour, IDomageble {
    [SerializeField] private float _damage;
    [SerializeField] private float _hp;
    
    [SerializeField] private float _speedAttack;
    private float _lastSpeedAttack;
    
    [SerializeField] private bool _dead = false;

    private Animator anim;

    //Inisialize
    private void Awake() {
        _lastSpeedAttack = _speedAttack;
        anim = GetComponent<Animator>();
    }

    private void Update() {
        _speedAttack -= Time.deltaTime;
        if(_speedAttack <= 0 && _hp > 0)
        {
            _speedAttack = _lastSpeedAttack;
            Attack();
        }
        if(_dead != false)
        {
            Destroy(gameObject);
            _dead = false;
        }
    }
    
    //Attack - Coolduwn
    public void Attack()
    {
        IDomageble _character = GameObject.FindWithTag("Player").GetComponent<IDomageble>();
        _character.Damage(_damage);
    }


    public void Damage(float damage)
    {
        //if enemy hp <= 0 : you dead
        if(_hp <= 0)
            Dead();
        
        //else are enemy hit
        _hp -= damage;

        Debug.Log($"Player Attack : {damage}");
    }
    private void Dead()
    {
        anim.SetBool("isDead", true);
    }

    public int GetHP()
    {
        return (int)_hp;
    }
}