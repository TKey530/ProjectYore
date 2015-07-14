using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public interface IWeapon    //something every weapon will have
    {
        int MinDamage { get; set; }
        int Attack();   //method calculating the actual amount of damage done
    }
}
