using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class MainMenuHandler : UIMenuHandler
    {
        private void OnEnable() 
        {
            MainMenu.OnStateEnter += ShowMenu;
            MainMenu.OnStateExit += HideMenu;
        }

        private void OnDestroy()
        {
            MainMenu.OnStateEnter -= ShowMenu;
            MainMenu.OnStateExit -= HideMenu;
        }
    }
}
