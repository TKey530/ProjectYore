using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
   
	public void ReturnToGame()
    {
        Debug.Log("Returning to game");
        this.GetComponentInParent<UIManager>().showPauseMenu = false;
        this.GetComponent<Canvas>().enabled = false;
        
    }

    public void ExitToMainMenu()
    {
        Debug.Log("Exiting to main menu");
        Application.LoadLevel(0);

    }

    public void SaveGame()
    {
        GameController.control.Save();
    }
}
