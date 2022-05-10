using UnityEngine;
using UIKit;

namespace snakefever
{
    public class UIActivityParser : MonoBehaviour
    {
        [SerializeField] private UIVisibilityManager _visibilityManager;

        public void TryParseSelect(UISelectable selectable)
        {
            if (_visibilityManager.AllActive)
            {
                selectable.Select();
            }
        }

        public void TryParseDeselect(UISelectable selectable)
        {
            if (_visibilityManager.AllActive)
            {
                selectable.Deselect();
            }
        }

        public void TryParseInteract(UIInteractable interactable)
        {
            if (_visibilityManager.AllActive)
            {
                interactable.Submit();
            }
        }
    }
}
