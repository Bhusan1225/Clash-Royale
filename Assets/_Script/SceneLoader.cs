using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Keep this object persistent across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public string sceneName;  // Set this in the Inspector

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
