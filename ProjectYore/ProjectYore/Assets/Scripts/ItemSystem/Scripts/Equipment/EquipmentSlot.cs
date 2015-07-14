using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public class EquipmentSlot : IEquipmentSlotIS
    {
        [SerializeField]
        string name;
        [SerializeField]
        Sprite icon;

        public EquipmentSlot()
        {
            name = "default name";
            icon = new Sprite();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sprite Icon
        {
            get { return icon; }
            set { icon = value; }
        }
    }
}
