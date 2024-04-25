using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelector : MonoBehaviour
{
    public GameObject backToMenuButton;
    public void LoadScene(string sceneToLoad)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
        backToMenuButton.SetActive(true);
        
    }
}
