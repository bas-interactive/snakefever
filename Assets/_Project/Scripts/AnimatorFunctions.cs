using UnityEngine;

namespace snakefever
{
    public class AnimatorFunctions : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void SetBoolTrue(string name)
        {
            _animator.SetBool(name, true);
        }

        public void SetBoolFalse(string name)
        {
            _animator.SetBool(name, false);
        }
    }
}
