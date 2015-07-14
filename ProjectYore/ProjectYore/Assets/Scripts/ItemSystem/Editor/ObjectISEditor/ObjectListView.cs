//ObjectListView is responsible for showing the created items on the left panel of the editor screen

using UnityEngine;
using UnityEditor;
using System.Collections;


namespace ProjectYore.ItemSystem.Editor
{
    public partial class ObjectEditor
    {
        Vector2 scrollPos = Vector2.zero;
        int listViewWidth = 200;
        int listViewButton = 190;
        int listViewHeight = 30;

        int selectedIndex = -1;

        void ListView()
        {
            if (state != DisplayState.NONE)
                return;

            scrollPos = EditorGUILayout.BeginScrollView(scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(listViewWidth));
            GUILayout.Label("asdf");
            for (int cnt = 0; cnt < weaponDatabase.Count; cnt++ )
            {
                if(GUILayout.Button(weaponDatabase.Get(cnt).Name, "box", GUILayout.Width(listViewButton), GUILayout.Height(listViewHeight)))
                {
                    tempWeapon = new Weapon(weaponDatabase.Get(cnt));
                    state = DisplayState.WEAPON_DETAILS;
                    toggleItemCreation = true;
                    selectedIndex = cnt;
                }
            }


            EditorGUILayout.EndScrollView();
        }
    }
}
