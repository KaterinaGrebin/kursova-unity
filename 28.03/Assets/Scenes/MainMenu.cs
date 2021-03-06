using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioSource bgSound;


    public void PlayGame()
    {
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        bgSound.Play();
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void MenuPressed()
    {
        SceneManager.LoadScene(0);
    }

}
