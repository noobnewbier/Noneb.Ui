using System.Collections.Generic;
using UnityEngine;

namespace Noneb.Ui.Runtime.Core.View
{
    public class NonebView : MonoBehaviour
    {
        private NonebView? _parent;
        private ISet<NonebView> _childViews;

        private void Init()
        {
            _parent = FindParentView(transform.parent);
            _childViews = FindDirectChildren();
        }

        private ISet<NonebView> FindDirectChildren()
        {
            throw new System.NotImplementedException();
        }

        private NonebView? FindParentView(Transform? parentTransform)
        {
            if (parentTransform == null)
            {
                return null;
            }

            var parentView = parentTransform.GetComponent<NonebView>();
            // ReSharper disable once TailRecursiveCall, dude this is just more readable
            return parentView ? parentView : FindParentView(parentTransform.parent);
        }
    }
}