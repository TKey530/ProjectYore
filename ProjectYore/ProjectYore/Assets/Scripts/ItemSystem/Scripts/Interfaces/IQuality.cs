//the absolute base item system quality.  
//Any class that implements this interface MUST implement the members of the interface
//this interface is implemented by the Quality class
//Every quality type will have a name and an associated icon

using UnityEngine;
using System.Collections;

namespace ProjectYore.ItemSystem
{
    public interface IQuality
    {
        string Name { get; set; }
        Sprite Icon { get; set; }
    }
}
