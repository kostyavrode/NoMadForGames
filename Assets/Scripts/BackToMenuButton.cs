using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenuButton : MonoBehaviour
{
    public void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuu");
        Destroy(this.gameObject);
    }
}
