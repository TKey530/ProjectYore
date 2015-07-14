using UnityEngine;
using UnityEditor;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    [System.Serializable]
    public class Object : IObject
    {
        #region Variables
        [SerializeField]
        string name;
        [SerializeField]
        Sprite icon;
        [SerializeField]
        int itemValue;
        [SerializeField]
        int burden;

        public QualityTypes quality;
        #endregion
        #region Constructors
        public Object()
        { }

        public Object(Object item)
        {
            ObjectClone(item);
        }
        #endregion
        #region getters/setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Value
        {
            get { return itemValue; }
            set { itemValue = value; }
        }

        public Sprite Sprite
        {
            get { return icon; }
            set { icon = value; }
        }

        public int Burden
        {
            get { return burden; }
            set { burden = value; }
        }
        #endregion

        public void ObjectClone(Object item)
        {
            name = item.Name;
            icon = item.Sprite;
            itemValue = item.Value;
            burden = item.Burden;
            quality = item.quality;
        }
        public virtual void OnGUI()
        {
            GUILayout.BeginVertical();

            name = EditorGUILayout.TextField("Name: ", name);
            itemValue = EditorGUILayout.IntField("Item value: ", itemValue);
            burden = EditorGUILayout.IntField("Burden: ", burden);

            DisplayIcon();
            DisplayQualityTypes();

            GUILayout.EndVertical();
        }
        public void DisplayIcon()
        {
            icon = EditorGUILayout.ObjectField("Weapon Icon: ", icon, typeof(Sprite), false) as Sprite;
        }
        public void DisplayQualityTypes()
        {
            quality = (QualityTypes)EditorGUILayout.EnumPopup("Quality Level", quality);
        }





        




    }
}