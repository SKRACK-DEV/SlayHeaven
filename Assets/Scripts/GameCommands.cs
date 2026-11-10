using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class GameCommands : MonoBehaviour
{
    [SerializeField] private DialogueRunner dialogueRunner;
    [SerializeField] private string menuSceneName = "MainMenu";

    private void Awake()
    {
        dialogueRunner.AddCommandHandler("menu", GoToMenu);
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene(menuSceneName);  //póŸniej mo¿na poprawiæ bo menu ma jedn¹ nazwê chyba ¿e doda sb inne menu
    }



}
