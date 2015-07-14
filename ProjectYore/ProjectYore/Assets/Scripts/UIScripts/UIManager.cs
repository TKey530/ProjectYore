using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public bool showPauseMenu = false;


	// Use this for initialization
	void Start()
    {
        this.GetComponentInChildren<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        ScanForKeyStroke();
	}

    void ScanForKeyStroke()
    {
        if (Input.GetKeyDown("escape"))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (!showPauseMenu)
        {
            Debug.Log("Opening the pause menu");
            this.GetComponentInChildren<Canvas>().enabled = true;

        }
        else if (showPauseMenu)
        {
            Debug.Log("Closing the pause menu");
            this.GetComponentInChildren<Canvas>().enabled = false;
        }

        showPauseMenu = !showPauseMenu;

    }

   
}
