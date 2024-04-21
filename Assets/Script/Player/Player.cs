using UnityEngine;

public class Player : MonoBehaviour, IDomageble {
    
    //Enemy Tag
	[Header ("Теги врагов")]

    [SerializeField] private string enemyString;

    //Parametrs
	[Header ("Параметры")]
    [Header ("Здоровье")]
	[SerializeField] private int _hp;
    [Header ("Урон")]
    [SerializeField] private float _damage;
    
    //General Event
    private Heal healEvent;

    //Initialize
    public void Initialize(Heal _heal)
    {
        healEvent = _heal;
        healEvent.Initialize(_hp);
        healEvent.Dead += Dead;
    }

    //TabDamage ^_____^
    public void TabDamage()
    {
        Attack();
    }

    //Attack Player
    public void Attack()
    {
        IDomageble _character = null;
        try
        {
            _character = GameObject.FindWithTag(enemyString).GetComponent<IDomageble>();

        }
        catch
        {
            Debug.LogWarning("Нет врага на сцене");
        }
        finally
        {
            _character.Damage(_damage);
        }
    }
    //Damage Player
    public void Damage(float damage)
    {
        healEvent.TakeDamage(damage);
        Debug.Log($"Enemy Attack : {damage}");
    }
    //X_X
    private void Dead() => Debug.Log("you dead!");

    public int GetHP()
    {
        return healEvent.GetValue();
    }
}