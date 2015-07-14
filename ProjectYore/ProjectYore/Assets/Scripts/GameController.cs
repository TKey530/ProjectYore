//A persistant game object
//health, experience
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameController : MonoBehaviour {

    public static GameController control;   //public static reference variable
    public float health;
    public int experience;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);  //this game object will not be destroyed when loading a new scene
            control = this;     //control now becomes the game object this script is attached to, which should be attached to the game controller
        }
        else if (control != this) //if control does exist but it is not "this" game object
        {
            Destroy(gameObject);    //only want one copy of this class
        }
    }

    

    //this will be the method to save data
    public void Save()
    {
        Debug.Log("Saving game");

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerinfo.dat");

        PlayerData data = new PlayerData();
        data.health = health;
        data.experience = experience;

        bf.Serialize(file, data);   //takes the serialize class 'data' and writes is to data
        file.Close();
    }

    //read from a file
    public void Load()  
    {
        //need to make sure the file exists before trying to open it
        if(File.Exists(Application.persistentDataPath + "/playerinfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
        }
    }
}

[Serializable]  //tells unity that this class can be written to a file.  This private class will hold the variables that are to be saved
class PlayerData
{
    public float health;
    public int experience;
}
