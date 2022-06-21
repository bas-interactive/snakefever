using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class JoinLobbyMenuHandler : UIMenuHandler
    {
        private void OnEnable() 
        {
            JoinLobbyMenu.OnStateEnter += ShowMenu;
            JoinLobbyMenu.OnStateExit += HideMenu;
        }

        private void OnDestroy()
        {
            JoinLobbyMenu.OnStateEnter -= ShowMenu;
            JoinLobbyMenu.OnStateExit -= HideMenu;
        }
    }
}
