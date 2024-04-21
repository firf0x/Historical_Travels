using UnityEngine;
using UnityEngine.UI;

namespace Assets.Resources.Config.Solders
{
    [CreateAssetMenu(fileName = "New CellSolder", menuName = "CellSolder")]
    public class CellSolder : ScriptableObject {
        [SerializeField] private string _id;
        [SerializeField] private Sprite _image;
        [SerializeField] private Button _button;
        [SerializeField] private float _attackDamage;
        [SerializeField] private int _money;

        public string Id => this._id;
        public Sprite Image => this._image;
        public Button Button => this._button;
        public float AttackDamage => this._attackDamage;
        public int Money => this._money;
    }
}
