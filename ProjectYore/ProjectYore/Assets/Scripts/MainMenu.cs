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

        public void StartLevel()
        {
            Debug.Log("Start level");
            Application.LoadLevel(1);
        }

        public void ExitGame()
        {
            Debug.Log("Exit game");
            Application.Quit();
        }

    }
}