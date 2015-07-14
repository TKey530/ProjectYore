//this class includes a basic constructor for the different quality types. 
//each quality type has its own name and an associated icon.
//for now, there will only be one quality type of name "common"
//this class inherits the IQuality interface

using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public class Quality : IQuality
    {
        [SerializeField]
        string name;
        [SerializeField]
        Sprite icon;

        public Quality()
        {
            icon = new Sprite();
            name = "default";    //by default, set name of the quality to common
        }

        public Quality(string Name, Sprite Icon)
        {
            name = Name;
            icon = Icon;
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