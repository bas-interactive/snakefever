using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace snakefever
{
    public class JoinLobbyMenuFunctions : MonoBehaviour
    {
        [SerializeField] public InputField _inputField;

        public void JoinRoom()
        {
            if (_inputField == null)
            {
                Debug.Log("Input Field is null.", gameObject);
                return;
            }

            
        }

        public void StartQuickplay()
        {

        }

        public void Quit()
        {
            GameManager.Instance.GameStateMachine.CurrentState.EnterMainMenu();
        }
    }
}
