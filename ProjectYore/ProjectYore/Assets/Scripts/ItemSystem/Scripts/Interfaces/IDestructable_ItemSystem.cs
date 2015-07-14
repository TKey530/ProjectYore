using UnityEngine;
using System.Collections;

//Interface for destructable items created with the item system
namespace ProjectYore.ItemSystem
{

    public interface IDestructable_ItemSystem
    {
        int Durability { get; } //can only get the durability, can't set it
        int MaxDurability { get; }

        void TakeDamage(int amount);
        void Repair();
        void Break();
    }
}
