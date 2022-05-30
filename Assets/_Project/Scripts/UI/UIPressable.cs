using UnityEngine;
using UnityEngine.Events;

namespace snakefever
{
    public class UIPressable : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        [SerializeField] private string _pressedBool = "pressed";

        [SerializeField] private UnityEvent OnPressEvent;

        public void OnPress()
        {
            OnPressEvent?.Invoke();

            _animator.SetBool(_pressedBool, true);
        }

        public void ResetBool()
        {
            _animator.SetBool(_pressedBool, false);
        }
    }
}
