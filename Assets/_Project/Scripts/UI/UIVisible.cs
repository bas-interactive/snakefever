using UnityEngine;
using UIKit;

namespace snakefever
{
    public class UIVisible : MonoBehaviour, IUIVisible
    {
        [Header("Components")]
        [SerializeField] private Animator _animator;

        [Header("Animation Parameters")]
        [SerializeField] private string _visibleBool = "visible";

        public void Show()
        {
            _animator.SetBool(_visibleBool, true);
        }

        public void Hide()
        {
            _animator.SetBool(_visibleBool, false);
        }
    }
}
