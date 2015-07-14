using UnityEngine;
using UnityEditor;
using System.Collections;

namespace ProjectYore.ItemSystem.Editor
{
    public partial class ObjectEditor
    {
        enum DisplayState
        {
            NONE,
            WEAPON_DETAILS,
            ARMOR_DETAILS
        };

        Weapon tempWeapon = new Weapon();
        bool toggleItemCreation = false;

        DisplayState state = DisplayState.NONE;

        void ItemDetails()
        {
            GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            switch(state)
            {
                case DisplayState.WEAPON_DETAILS:
                    if (toggleItemCreation)
                    {
                        CreateNewWeapon();
                    }
                    break;
                case DisplayState.ARMOR_DETAILS:
                    if(toggleItemCreation)
                    {
                        CreateNewArmor();
                    }
                    break;
                default:
                    break;
            }

            
            GUILayout.EndHorizontal();

            GUILayout.Space(4);

            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
            DisplayButtons();
            GUILayout.EndHorizontal();

            
            

            GUILayout.EndVertical();

        }

        void CreateNewWeapon()
        {

            GUILayout.BeginVertical();
            tempWeapon.OnGUI();
            GUILayout.EndVertical();

        }

        void CreateNewArmor()
        {
            Debug.Log("Creating a new piece of armor");
        }

        void DisplayButtons()
        {
            if (!toggleItemCreation)
            {
                if (GUILayout.Button("Create Weapon"))
                {
                    tempWeapon = new Weapon();
                    toggleItemCreation = true;
                    state = DisplayState.WEAPON_DETAILS;
                }

                if(GUILayout.Button("Create Armor"))
                {
                    state = DisplayState.ARMOR_DETAILS;
                    toggleItemCreation = true;
                }
            }
            else
            {
//                GUI.SetNextControlName("SaveButton");

                if (GUILayout.Button("Save"))
                {
                    if (selectedIndex == -1)
                        weaponDatabase.Add(tempWeapon);
                    else
                        weaponDatabase.Replace(selectedIndex, tempWeapon);

                    toggleItemCreation = false;
                    tempWeapon = null;
                    selectedIndex = -1;
                    state = DisplayState.NONE;
//                    GUI.FocusControl("SaveButton");
                }

                if (selectedIndex != -1)
                {
                    if (GUILayout.Button("Delete"))
                    {
                        if (EditorUtility.DisplayDialog("Delete Weapon", "Delete " + weaponDatabase.Get(selectedIndex).Name + " from the database?",
                                                   "Delete",
                                                   "cancel")
                                                   )
                        {
                            weaponDatabase.Remove(selectedIndex);
                            toggleItemCreation = false;
                            tempWeapon = null;
                            selectedIndex = -1;
                            state = DisplayState.NONE;
 //                           GUI.FocusControl("SaveButton");
                        }
                    }
                }

                if (GUILayout.Button("Cancel"))
                {
                    toggleItemCreation = false;
                    tempWeapon = null;
                    selectedIndex = -1;
                    state = DisplayState.NONE;
//                    GUI.FocusControl("SaveButton");
                }
            }
        }
    }
}
