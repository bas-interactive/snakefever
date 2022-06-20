using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class JoinLobbyMenuHandler : UIMenuHandler
    {
        private void OnEnable() 
        {
            JoinLobbyMenu.OnJoinLobbyMenuEnter += ShowMenu;
            JoinLobbyMenu.OnJoinLobbyMenuExit += HideMenu;
        }

        private void OnDestroy()
        {
            JoinLobbyMenu.OnJoinLobbyMenuEnter -= ShowMenu;
            JoinLobbyMenu.OnJoinLobbyMenuExit -= HideMenu;
        }
    }
}
