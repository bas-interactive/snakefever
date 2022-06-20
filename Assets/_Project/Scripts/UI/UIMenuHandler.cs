using UnityEngine;

namespace snakefever
{
    public class UIMenuHandler : MonoBehaviour
    {
        [SerializeField] protected UIVisibilityManager _visibilityManager;

        protected void ShowMenu()
        {
            SetMenuActive();
            _visibilityManager.ShowElements();
        }

        protected void HideMenu()
        {
            _visibilityManager.HideElements();
            _visibilityManager.OnComplete += SetMenuInactiveIfExited;
        }

        protected void SetMenuActive()
        {
            _visibilityManager.gameObject.SetActive(true);
        }

        protected void SetMenuInActive()
        {
            _visibilityManager.gameObject.SetActive(false);
        }

        protected void SetMenuInactiveIfExited()
        {
            if (!_visibilityManager.AllActive)
            {
                SetMenuInActive();
            }
        }
    }
}
