using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class MainMenuHandler : UIMenuHandler
    {
        private void OnEnable() 
        {
            MainMenu.OnMainMenuEnter += ShowMenu;
        }

        private void OnDestroy()
        {
            MainMenu.OnMainMenuEnter -= ShowMenu;
        }
    }
}
