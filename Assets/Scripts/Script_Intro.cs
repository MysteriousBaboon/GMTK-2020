using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Script_Intro : MonoBehaviour
{
    public VideoPlayer Video;
    public string SceneName;

    void Start()
    {
        Video.loopPointReached += LoadScene;
    }

    void Update()
    {
        
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneName);
    }
}
