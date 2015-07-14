using UnityEngine;
using UnityEditor;
using System.Collections;

namespace ProjectYore.ItemSystem.Editor
{
    public partial class ObjectEditor : EditorWindow
    {
        WeaponDatabase weaponDatabase;

        const string WEAPON_DATABASE_NAME = "WeaponDatabase.asset";
        const string DATABASE_PATH = "Database";
        const string DATABASE_FULL_PATH = @"Assets"+ "/" + DATABASE_PATH + "/" + WEAPON_DATABASE_NAME;

        [MenuItem("RO4/Database/ItemEditor #%o")]
        public static void Init()  //this line is called
        {
            ObjectEditor window = EditorWindow.GetWindow<ObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent.text = "Item System";
            window.Show();
        }

        void OnEnable()
        {
            
            if (weaponDatabase == null)
            {
                weaponDatabase = WeaponDatabase.GetDatabase<WeaponDatabase>(DATABASE_PATH, WEAPON_DATABASE_NAME);
            }
        }

        void OnGUI()
        {
            TopTabBar();

            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();

            BottomStatusBar();
        }
    }
}