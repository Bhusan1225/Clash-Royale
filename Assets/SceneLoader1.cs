using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
    public static SceneLoader1 Instance;

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
