using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem.Editor
{
    public partial class ObjectEditor
    {
        void TopTabBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            WeaponsTab();
            ArmorTab();
            PotionsTab();
            AboutTab();
            
            GUILayout.EndHorizontal();
        }

        void WeaponsTab()
        {
            GUILayout.Button("Weapons");
        }

        void ArmorTab()
        {
            GUILayout.Button("Armor");
        }

        void PotionsTab()
        {
            GUILayout.Button("Potions");
        }

        void AboutTab()
        {
            GUILayout.Button("About");
        }
    }
}
