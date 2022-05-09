using UnityEngine;
using UIKit;

namespace snakefever
{
    public class UIVisibilityManager : UIVisibilityHandler
    {
        [SerializeField] private float _showDelay = 0.25f;

        private void Awake()
        {
            ResetObjects();
        }

        public void ShowElements()
        {
            SetVisible(_showDelay, true);
        }

        public void HideElements()
        {
            SetVisible(_showDelay, false);
        }
    }
}
