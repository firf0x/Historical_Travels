using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackGroundController : MonoBehaviour, IEnableBackGroundController
{
    private Move MoveBG;
	[Header ("Скорость сцены")]
    [SerializeField] private float speed;
    private Material mat;

    public void Initialize(Move _move) {
        mat = gameObject.GetComponent<Image>().material;

        this.MoveBG = _move;
        _move.Initialize(speed);
        this.MoveBG.MoveInfo += MessageLog;
        this.MoveBG.moveObject += MoveBackGround;
    }

    public void EnableMove()
    {
        MoveBG.moveObject += MoveBackGround;
    }
    public void DisableMove()
    {
        MoveBG.moveObject -= MoveBackGround;
    }
    private void Update()
    {
        MoveBG.Moved();
        //MoveBG.Info();
    }

    
    private void MessageLog(string message) => Debug.Log(message);

    private void MoveBackGround(float result) => mat.mainTextureOffset = new Vector2(result, 0);
}
