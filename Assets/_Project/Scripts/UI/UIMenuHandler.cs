using UnityEngine;

namespace snakefever
{
    public class UIMenuHandler : MonoBehaviour
    {
        [SerializeField] private UIVisibilityManager _visibilityManager;

        private void Start()
        {
            _visibilityManager.ShowElements();
        }
    }
}
