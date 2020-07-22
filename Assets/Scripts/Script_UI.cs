using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Script_UI : MonoBehaviour
{
    public string levelName;
    private GameObject go;

    public void GotoScene()
    {
        SceneManager.LoadScene(levelName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
