using UnityEngine;
using UIKit;

namespace snakefever
{
    public class UIActivity : MonoBehaviour
    {
        [SerializeField] private UIActivityParser _activityParser;
        [SerializeField] private UISelectable _selectable;
        [SerializeField] private UIInteractable _interactable;

        public void ParseSelect()
        {
            _activityParser.TryParseSelect(_selectable);
        }

        public void ParseDeselect()
        {
            _activityParser.TryParseDeselect(_selectable);
        }

        public void ParseInteract()
        {
            _activityParser.TryParseInteract(_interactable);
        }
    }
}
