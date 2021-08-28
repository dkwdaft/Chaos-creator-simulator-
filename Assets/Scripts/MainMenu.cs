using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void Start()
    {
        audioMixer.SetFloat("volume", AudoManager.globalvolume);
    }

    public void Play()
    {
        SceneManager.LoadScene("leval");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

   public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

   public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
