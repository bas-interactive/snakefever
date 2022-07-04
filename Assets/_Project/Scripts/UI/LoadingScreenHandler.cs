using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class LoadingScreenHandler : UIMenuHandler
    {
        private void OnEnable() 
        {
            LoadingScreen.OnStateEnter += ShowMenu;
            LoadingScreen.OnStateExit += HideMenu;
        }

        private void OnDestroy()
        {
            LoadingScreen.OnStateEnter -= ShowMenu;
            LoadingScreen.OnStateExit -= HideMenu;
        }
    }
}
