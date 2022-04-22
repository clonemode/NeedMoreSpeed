using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume (float volume)
        {
        audioMixer.SetFloat("volume", volume);
        }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        PauseMenu.IsPaused = false;
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
