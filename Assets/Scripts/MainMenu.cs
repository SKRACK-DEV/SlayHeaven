using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "Game";

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR  //to do edycji póŸniej bo to tylko do testowania w editorze, nie potrzebne w final wersji
        UnityEditor.EditorApplication.isPlaying = false;  

#else
            Application.Quit();

#endif

    }
}
