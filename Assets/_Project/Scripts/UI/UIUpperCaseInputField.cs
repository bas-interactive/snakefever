using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace snakefever
{
    [RequireComponent(typeof(InputField))]
    public class UIUpperCaseInputField : MonoBehaviour
    {
        private InputField _inputField;

        private void Awake()
        {
            _inputField = GetComponent<InputField>();
        }

        void Start()
        {
            _inputField.onValidateInput +=  delegate (string s, int i, char c) { return char.ToUpper(c); };
        }
    }
}
