using UnityEngine;

namespace snakefever
{
    public class UISelectable : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _selectedBool = "selected";

        public void OnSelect()
        {
            _animator.SetBool(_selectedBool, true);
        }

        public void OnDeSelect()
        {
            _animator.SetBool(_selectedBool, false);
        }
    }
}
