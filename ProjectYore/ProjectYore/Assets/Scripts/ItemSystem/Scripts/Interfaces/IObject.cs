//the absolute base item system object.  
//Any class that implements this interface MUST implement the members of the interface
//this interface is implemented by the Object class
//every object will have a name, a currency value, an associated sprite, burden value(for inventory purposes, and a quality type


using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public interface IObject
    {
        //name
        //value - gold
        //icon
        //item weight


        string Name { get; set; }
        int Value { get; set; }
        Sprite Sprite { get; set; }
        int Burden { get; set; }  //how much the item weights in relation to the inventory



        //equipable
        //questItemFlag
        //durability
        //takeDamage
        //prefab

    }
}