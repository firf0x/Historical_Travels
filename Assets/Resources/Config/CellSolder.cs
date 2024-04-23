using UnityEngine;
using UnityEngine.UI;

namespace Assets.Resources.Config
{
    [CreateAssetMenu(fileName = "New CellSolder", menuName = "CellSolder")]
    public class CellSolder : ScriptableObject {
        [SerializeField] private string _id;
        [SerializeField] private Sprite _image;
        [SerializeField] private float _attackDamage;
        [SerializeField] private int _cost;

        public string Id => this._id;
        public Sprite Image => this._image;
        public float AttackDamage => this._attackDamage;
        public int Cost => this._cost;
    }
}