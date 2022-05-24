using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class UIPressable : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        [SerializeField] private string _pressedBool = "pressed";

        public void OnSelect()
        {
            _animator.SetBool(_pressedBool, true);
            Debug.Log("aaaaaaaa");
        }
    }
}
