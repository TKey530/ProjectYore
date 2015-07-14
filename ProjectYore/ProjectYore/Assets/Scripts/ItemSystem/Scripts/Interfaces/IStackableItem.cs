using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public interface IStackableItem
    {
        int Stack(int amount);  //default value of zero
        int MaxStack { get; }

    }
}