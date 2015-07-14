using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public interface IArmor    
    {
        int ArmorRating { get; set; }
        int Defend();   
    }
}
