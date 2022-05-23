using System;
using UnityEngine;

namespace snakefever
{
    public class TransitionManager : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _fadeInAnimation;
        [SerializeField] private string _fadeOutAnimation;

        public event Action OnFadeInComplete;
        public event Action OnFadeOutComplete;

        public void FadeIn()
        {
            _animator.Play(_fadeInAnimation);
        }

        public void FadeOut()
        {
            _animator.Play(_fadeOutAnimation);
        }

        public void FadeInComplete()
        {
            OnFadeInComplete?.Invoke();
        }

        public void FadeOutComplete()
        {
            OnFadeOutComplete?.Invoke();
        }
    }
}
