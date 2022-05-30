using System;
using System.Collections;
using UnityEngine;

namespace snakefever
{
    public class TransitionManager : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _fadeInAnimation;
        [SerializeField] private string _fadeOutAnimation;
        [SerializeField] private float _duration;

        public event Action OnFadeInComplete;
        public event Action OnFadeOutComplete;

        public void FadeIn()
        {
            StopAllCoroutines();
            
            StartCoroutine(PlayFadeInAnimation());
        }

        public void FadeOut()
        {
            StopAllCoroutines();

            StartCoroutine(PlayFadeOutAnimation());
        }

        private IEnumerator PlayFadeOutAnimation()
        {
            _animator.Play(_fadeOutAnimation);

            yield return new WaitForSeconds(_duration);

            FadeOutComplete();
        }

        private IEnumerator PlayFadeInAnimation()
        {
            _animator.Play(_fadeInAnimation);

            yield return new WaitForSeconds(_duration);

            FadeInComplete();
        }

        private void FadeInComplete()
        {
            OnFadeInComplete?.Invoke();
        }

        private void FadeOutComplete()
        {
            OnFadeOutComplete?.Invoke();
        }
    }
}
