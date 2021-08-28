using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameOver : MonoBehaviour
{
    
    public TMP_Text scoreText;

    public AudioMixer audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Your score: " + LevalManager.points;
        audioMixer.SetFloat("volume", AudoManager.globalvolume);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("leval");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
