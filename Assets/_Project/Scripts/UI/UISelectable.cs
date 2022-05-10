using UnityEngine;
using UIKit;

namespace snakefever
{
    public class UISelectable : MonoBehaviour, IUISelectable
    {
        [Header("Components")]
        [SerializeField] private Animator _animator;

        [Header("Animation Parameters")]
        [SerializeField] private string _selectableBool = "selected";

        public void Select()
        {
            _animator.SetBool(_selectableBool, true);
        }

        public void Deselect()
        {
            _animator.SetBool(_selectableBool, false);
        }

        public GameObject GetGameObject()
        {
            return gameObject;
        }
    }
}
