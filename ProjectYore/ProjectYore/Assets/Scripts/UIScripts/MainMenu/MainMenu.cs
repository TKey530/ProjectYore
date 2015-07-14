using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace MainMenu
{
    public class MainMenu : MonoBehaviour
    {

        public Canvas quitMenu;
        public Button startText;
        public Button exitText;

        void Start()
        {
            quitMenu = quitMenu.GetComponent<Canvas>();
            quitMenu.enabled = false;
            startText = startText.GetComponent<Button>();
            exitText = exitText.GetComponent<Button>();
        }

        public void ExitPressed()
        {
            Debug.Log("Exit game?");
            quitMenu.enabled = true;
            startText.enabled = false;
            exitText.enabled = false;
        }

        public void ReturnToMainMenu()
        {
            Debug.Log("Return to main menu");
            quitMenu.enabled = false;
            startText.enabled = true;
            exitText.enabled = true;
        }

        public void StartNewGame()
        {
            Debug.Log("Start level");
            Application.LoadLevel(1);
//            Debug.Log(GameController.UI.showPauseMenu.ToString());
        }

        public void LoadSavedGame()
        {
            Debug.Log("Loading a saved game");
            GameController.control.Load();
        }
        public void ExitGame()
        {
            Debug.Log("Exit game");
            Application.Quit();
        }

    }
}