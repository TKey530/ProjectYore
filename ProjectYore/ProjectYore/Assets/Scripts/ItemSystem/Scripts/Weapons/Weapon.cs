using UnityEngine;
using UnityEditor;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    [System.Serializable]
    public class Weapon : Object, IWeapon, IDestructable_ItemSystem, IGameObjectItemSystem
    {
        #region variables
        [SerializeField]
        int minDamage;

        [SerializeField]
        int durability;

        [SerializeField]
        int maxDurability;

        [SerializeField]
        GameObject itemPrefab;

        public EquipSlot equipSlot;

        
        #endregion

        #region Constructors
        
        public Weapon()
        { }

        public Weapon(Weapon weapon)
        {
            WeaponClone(weapon);
        }
        #endregion

        public void WeaponClone(Weapon weapon)
        {
            base.ObjectClone(weapon);

            minDamage = weapon.minDamage;
            durability = weapon.durability;
            maxDurability = weapon.maxDurability;
            equipSlot = weapon.equipSlot;
            itemPrefab = weapon.itemPrefab;
        }

        #region IWeapon Implementation
        public int MinDamage
        {
            get{return minDamage;}

            set { minDamage = value; }

        }

        public int Attack()
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

            minDamage = EditorGUILayout.IntField("Minimum Damage: ", minDamage);
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
