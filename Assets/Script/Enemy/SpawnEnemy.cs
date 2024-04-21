using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour, ISpawn
{
    // Список противников
    [SerializeField] private List<GameObject> listPrefabs = new List<GameObject>{};
    
    // Класс Таймера
    private Timer _timer;

    // Параметры
    [SerializeField] private float MaxTime;
    private int randomInt;

    // Скрытые компоненты юнити
    private Animator anim;

    // Инициализация
    private void Awake()
    {
        _timer = new Timer(MaxTime);
    }

    //Проверяет есть ли противник на сцене если нет то спавнит его через определённое время
    ///<Summary>
    ///Надо будет переделать и закинуть в отдельный скрипт
    ///<Summary>
    private void Update() {
        _timer.Recalculation(Time.deltaTime);
        //Debug.Log(enemy);
        if(_timer.GetTime() <= 0)
        {
            if(GameObject.FindWithTag(listPrefabs[randomInt].tag) == null)
            {
                Spawn();
            }
        }
    }

    //Спавнит противника с прокидыванием анимации
    public void Spawn()
    {
        int rand = Random.Range(0, listPrefabs.Count);
        randomInt = rand;
        anim = listPrefabs[rand].GetComponent<Animator>();
        Instantiate(listPrefabs[rand], gameObject.transform);
        Debug.Log(listPrefabs[rand] + "   " + MaxTime);
    }
}
