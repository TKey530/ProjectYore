using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem.Editor
{
    public partial class ObjectEditor
    {
        void BottomStatusBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            GUILayout.Label("Status Bar");
            GUILayout.EndHorizontal();
        }

    }
}
