using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Script_UI : MonoBehaviour
{
    public string levelName;
    public float radiusAugmentation = 0;
    private GameObject go;

    public void GotoScene()
    {
        SceneManager.LoadScene(levelName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Upradius()
    {
        go = GameObject.FindGameObjectsWithTag("Player")[0];
        go.gameObject.GetComponent<Script_Player>().radius += radiusAugmentation;
    }


}
