using UnityEngine;
using UnityEditor;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    [System.Serializable]
    public class Armor : Object, IArmor, IDestructable_ItemSystem, IGameObjectItemSystem
    {
        #region variables
        [SerializeField]
        int armorRating;

        [SerializeField]
        int durability;

        [SerializeField]
        int maxDurability;

        [SerializeField]
        GameObject itemPrefab;

        public EquipSlot equipSlot;


        #endregion

        #region Constructors

        public Armor()
        { }

        public Armor(Armor armor)
        {
            ArmorClone(armor);
        }
        #endregion

        public void ArmorClone(Armor armor)
        {
            base.ObjectClone(armor);

            armorRating = armor.armorRating;
            durability = armor.durability;
            maxDurability = armor.maxDurability;
            equipSlot = armor.equipSlot;
            itemPrefab = armor.itemPrefab;
        }

        #region IArmor Implementation
        public int ArmorRating
        {
            get { return armorRating; }

            set { armorRating = value; }

        }

        public int Defend()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region IDestructable implementation
        public int Durability
        {
            get { return durability; }
        }

        public int MaxDurability
        {
            get { return maxDurability; }
        }

        public void TakeDamage(int amount)
        {
            durability -= amount;

            if (durability < 0)
                durability = 0;

        }

        public void Repair()
        {
            maxDurability--;

            if (maxDurability < 0)
                durability = maxDurability;
        }

        public void Break()
        {
            durability = 0;
        }
        #endregion

        #region ItemPrefab Implementation
        public GameObject ItemPrefab
        {
            get { return itemPrefab; }
        }
        #endregion

        public override void OnGUI()
        {
            base.OnGUI();

            armorRating = EditorGUILayout.IntField("Armor Rating: ", armorRating);
            durability = EditorGUILayout.IntField("Durability: ", durability);
            maxDurability = EditorGUILayout.IntField("Max Durability: ", maxDurability);

            DisplayEquipmentSlot();
            DisplayItemPrefab();

        }

        public void DisplayEquipmentSlot()
        {
            equipSlot = (EquipSlot)EditorGUILayout.EnumPopup("Equipment Slot", equipSlot);
        }

        public void DisplayItemPrefab()
        {
            itemPrefab = EditorGUILayout.ObjectField("Prefab: ", itemPrefab, typeof(GameObject), false) as GameObject;
        }
    }
}
