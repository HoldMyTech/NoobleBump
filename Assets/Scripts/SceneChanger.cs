using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // System.Collections is not strictly necessary for this specific script

public class SceneAdvance : MonoBehaviour
{
    public string nextSceneName;

    // This method is called when the script is enabled in the scene
    void Start()
    {
        // Optional: You could add a check here to make sure a scene name is set.
    }
    
    public void LoadNextScene()
    {
     
        SceneManager.LoadScene(nextSceneName);
    }
}